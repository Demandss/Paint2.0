using Paint.exact;
using Paint.Tools.exact;

namespace Paint.Tools
{
    public class ToolFactory
    {
        public static DrawTool GetTool(Tools type)
        {
            switch (type)
            {
                case Tools.Circle:
                {
                    return new CircleTool();
                }
                case Tools.Eraser:
                {
                    return new EraserTool();
                }
                case Tools.Fill:
                {
                    return new FillTool();
                }
                case Tools.Line:
                {
                    return new LineTool();
                }
                case Tools.Pen:
                {
                    return new PenTool();
                }
                case Tools.Pipette:
                {
                    return new PipetteTool();
                }
                case Tools.Rectangle:
                {
                    return new RectangleTool();
                }
                case Tools.Selection:
                {
                    return new SelectionTool();
                }
                case Tools.Text:
                {
                    return new TextTool();
                }
            }
            return null;
        }
    }
}