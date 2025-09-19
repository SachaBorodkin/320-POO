using Drones.Helpers;

namespace Drones
{
    public partial class Building
    {
        private Pen buildingBrush = new Pen(new SolidBrush(Color.Red), 7);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(buildingBrush, new Rectangle(x, y, width, depth));
        }
    }
    public partial class ZavodRoshen : Building
    {
        private Brush buildingBrush = new SolidBrush(Color.Red);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildingBrush, new Rectangle(x, y, width, depth));
        }
    }
    public partial class ATB : Building
    {
        private Brush buildingBrush = new SolidBrush(Color.Blue);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(buildingBrush, new Rectangle(x, y, width, width));
        }
    }
}
