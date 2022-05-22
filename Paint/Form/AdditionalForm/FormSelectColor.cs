using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Paint.Form.Pattern;
using Paint.Utils;

namespace Paint.Form.AdditionalForm
{
    public partial class FormSelectColor : FormPattern
    {
        
        #region Fields
		private bool updatingFaders;
		private bool updatingRGBText;
		private bool updatingHexText;
		private Color selectedColor;

		private static FormSelectColor INSTANCE;

		#endregion Fields

		#region Events
		public event EventHandler SelectedColorChanged;
		public event EventHandler CloseRequested;
		public event EventHandler CancelRequested;
		#endregion Events

		#region Public properties

		public Color SelectedColor
		{
			get
			{
				return selectedColor;
			}
			set
			{
				if (value != selectedColor)
				{
					selectedColor = value;

					if (!updatingFaders)
					{
						faderRed.Ratio = value.R;
						faderGreen.Ratio = value.G;
						faderBlue.Ratio = value.B;
					}

					UpdateColors();

					if (SelectedColorChanged != null)
					{
						SelectedColorChanged(this, EventArgs.Empty);
					}
				}
			}
		}

		public string RgbText
		{
			get { return textRGB.Text; }
			set { textRGB.Text = value; }
		}

		public string HtmlText
		{
			get { return textHex.Text; }
			set { textHex.Text = value; }
		}
		#endregion Public properties

		#region Constructors
		
		public static FormSelectColor Get()
		{
			return INSTANCE;
		}
		
		public FormSelectColor()
		{
			InitializeComponent();
			UpdateComponentsRenderLevel();

			INSTANCE = this;
			
			RGBfader_RatioChanged(null, null);
		}
		#endregion Constructors

		#region Control event handlers
		
		private void FormSelectColor_Load(object sender, EventArgs e)
		{
			this.closeButton.Location = new Point(285, 6);
			this.scaleButton.Hide();
			this.skipButton.Hide();
		}
		
		#endregion Control event handlers

		#region Sub-control event handlers
		private void RGBfader_RatioChanged(object sender, EventArgs e)
		{
			if (!updatingFaders)
			{
				updatingFaders = true;

				Color rgb = Color.FromArgb(faderRed.Ratio, faderGreen.Ratio, faderBlue.Ratio);
				HslColor hsl = ColorMath.RgbToHsl(rgb);

				faderHue.Ratio = hsl.H;
				faderSaturation.Ratio = hsl.S;
				faderLightness.Ratio = hsl.L;

				SelectedColor = rgb;

				updatingFaders = false;
			}
		}

		private void HSLfader_RatioChanged(object sender, EventArgs e)
		{
			if (!updatingFaders)
			{
				updatingFaders = true;

				HslColor hsl = new HslColor(faderHue.Ratio, faderSaturation.Ratio, faderLightness.Ratio);
				Color rgb = ColorMath.HslToRgb(hsl);

				faderRed.Ratio = rgb.R;
				faderGreen.Ratio = rgb.G;
				faderBlue.Ratio = rgb.B;

				SelectedColor = rgb;

				updatingFaders = false;
			}
		}

		private void colorWheel1_HueChanged(object sender, EventArgs e)
		{
			updatingFaders = true;

			faderHue.Ratio = colorWheel1.Hue;

			HslColor hsl = new HslColor(faderHue.Ratio, faderSaturation.Ratio, faderLightness.Ratio);
			Color rgb = ColorMath.HslToRgb(hsl);

			faderRed.Ratio = rgb.R;
			faderGreen.Ratio = rgb.G;
			faderBlue.Ratio = rgb.B;

			SelectedColor = rgb;

			updatingFaders = false;
		}

		private void colorWheel1_SLChanged(object sender, EventArgs e)
		{
			updatingFaders = true;

			faderSaturation.Ratio = colorWheel1.Saturation;
			faderLightness.Ratio = colorWheel1.Lightness;

			HslColor hsl = new HslColor(faderHue.Ratio, faderSaturation.Ratio, faderLightness.Ratio);
			Color rgb = ColorMath.HslToRgb(hsl);

			faderRed.Ratio = rgb.R;
			faderGreen.Ratio = rgb.G;
			faderBlue.Ratio = rgb.B;

			SelectedColor = rgb;

			updatingFaders = false;
		}

		private void textRGB_TextChanged(object sender, EventArgs e)
		{
			if (!updatingRGBText)
			{
				updatingRGBText = true;

				try
				{
					Match m = Regex.Match(textRGB.Text.Trim().ToLower(), @"^rgb\(\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*\)$");
					if (m.Success)
					{
						int r = int.Parse(m.Groups[1].Value);
						int g = int.Parse(m.Groups[2].Value);
						int b = int.Parse(m.Groups[3].Value);
						if (r > 255) throw new FormatException();
						if (g > 255) throw new FormatException();
						if (b > 255) throw new FormatException();
						faderRed.Ratio = (byte) r;
						faderGreen.Ratio = (byte) g;
						faderBlue.Ratio = (byte) b;
					}
					else
					{
						throw new FormatException();
					}
					textRGB.BackColor = Color.Empty;
				}
				catch (FormatException)
				{
					textRGB.BackColor = ColorMath.Blend(SystemColors.Window, Color.Crimson, 0.3);
				}

				updatingRGBText = false;
			}
		}

		private void textHex_TextChanged(object sender, EventArgs e)
		{
			if (!updatingHexText)
			{
				updatingHexText = true;

				try
				{
					if (textHex.Text.Length == 0)
						throw new FormatException();
					if (textHex.Text[0] == '#' && textHex.Text.Length != 4 && textHex.Text.Length != 7)
						throw new FormatException();

					Color c = ColorTranslator.FromHtml(textHex.Text);
					faderRed.Ratio = c.R;
					faderGreen.Ratio = c.G;
					faderBlue.Ratio = c.B;

					textHex.BackColor = Color.Empty;
				}
				catch (Exception)
				{
					textHex.BackColor = ColorMath.Blend(SystemColors.Window, Color.Crimson, 0.3);
				}

				updatingHexText = false;
			}
		}

		private void picturePalette_Click(object sender, EventArgs e)
		{
			Control c = sender as Control;
			Color color = c.BackColor;
			faderRed.Ratio = color.R;
			faderGreen.Ratio = color.G;
			faderBlue.Ratio = color.B;
		}

		private void OKActionButton_Click(object sender, EventArgs e)
		{
			if (CloseRequested != null)
			{
				CloseRequested(this, EventArgs.Empty);
			}
		}

		private void CancelActionButton_Click(object sender, EventArgs e)
		{
			if (CancelActionButton.Text == "Больше >")
			{
				this.Size = new Size(600,this.Size.Height);
				CancelActionButton.Text = "Меньше <";
				this.closeButton.Location = new Point(560, 6);
				return;
			}
			this.Size = new Size(310,this.Size.Height);
			CancelActionButton.Text = "Больше >";
			this.closeButton.Location = new Point(285, 6);
		}
		#endregion Sub-control event handlers

		#region Management methods
		private void UpdateColors()
		{
			Color c = Color.FromArgb(faderRed.Ratio, faderGreen.Ratio, faderBlue.Ratio);

			faderRed.Color1 = Color.FromArgb(0, c.G, c.B);
			faderRed.Color2 = Color.FromArgb(255, c.G, c.B);

			faderGreen.Color1 = Color.FromArgb(c.R, 0, c.B);
			faderGreen.Color2 = Color.FromArgb(c.R, 255, c.B);

			faderBlue.Color1 = Color.FromArgb(c.R, c.G, 0);
			faderBlue.Color2 = Color.FromArgb(c.R, c.G, 255);

			HslColor hsl = new HslColor(faderHue.Ratio, faderSaturation.Ratio, faderLightness.Ratio);

			faderSaturation.Color1 = ColorMath.HslToRgb(new HslColor(hsl.H, 0, hsl.L));
			faderSaturation.Color2 = ColorMath.HslToRgb(new HslColor(hsl.H, 255, hsl.L));

			faderLightness.Color1 = ColorMath.HslToRgb(new HslColor(hsl.H, hsl.S, 0));
			faderLightness.ColorMid = ColorMath.HslToRgb(new HslColor(hsl.H, hsl.S, 128));
			faderLightness.Color2 = ColorMath.HslToRgb(new HslColor(hsl.H, hsl.S, 255));

			if (!updatingRGBText)
			{
				updatingRGBText = true;
				textRGB.Text = "rgb(" + c.R + ", " + c.G + ", " + c.B + ")";
				textRGB.BackColor = Color.Empty;
				updatingRGBText = false;
			}

			if (!updatingHexText)
			{
				updatingHexText = true;
				textHex.Text = "#" + c.R.ToString("x2") + c.G.ToString("x2") + c.B.ToString("x2");
				textHex.BackColor = Color.Empty;
				updatingHexText = false;
			}

			colorWheel1.Hue = hsl.H;
			colorWheel1.Saturation = hsl.S;
			colorWheel1.Lightness = hsl.L;
		}
		#endregion Management methods
    }
}