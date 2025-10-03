using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class ATB : Building //Magasin hérite de la batiment
    {
        private string _openingHours;                   //Horaire d'ouverture du magasin

        //Constructeur de la classe mmagasin(ATB)
        public ATB(string openingHours, int x, int y, int depth, int width) : base()
        {
            _openingHours = openingHours;                                               //Attribution de l'horaire
            Console.WriteLine("Nous sommes ouverts : " + openingHours);                 //Affichage de l'horaire

            //Attribution des coordonnées et dimensions
            this.x = x;                                                                 
            this.y = y;
            this.depth = depth;
            this.width = width;
        }
        //Dessin du magasin
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(buildingBrush, new Rectangle(x, y, width, width));
        }
    }
}
