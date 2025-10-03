```csharp
using Drones.Helpers;
using System.Drawing;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut visualiser un drone
    public partial class Drone
    {
        // Stylo graphique (Pen) utilisé pour dessiner le drone en violet avec une épaisseur de 3 pixels
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // Représentation graphique du drone
        public void Render(BufferedGraphics drawingSpace)
        {
            // Dessine une petite ellipse pour représenter le drone (sa position est centrée autour de x et y)
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 4, y - 2, 8, 8));

            // Dessine le nom du drone et son état (via ToString) à côté de sa position
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
        }

        // Représentation textuelle du drone
        public override string ToString()
        {
            // Retourne une chaîne sous la forme : NomDuDrone (Charge%)
            // Exemple : "DroneA (75%)" si la charge est 750 (sur 1000)
            return $"{name} ({((int)((double)charge / 1000 * 100)).ToString()}%)";
        }
    }
}
```
