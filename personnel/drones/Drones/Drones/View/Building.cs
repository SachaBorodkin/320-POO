using Drones.Helpers;

namespace Drones
{
    public partial class Building
    {
        private Pen buildingBrush = new Pen(new SolidBrush(Color.Red), 7);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(buildingBrush, new Rectangle(x, y, width, deepth));
        }
    }
}
