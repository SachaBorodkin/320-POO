using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Drones
{
    //Déclaration de la classe parente pour héritage
    public abstract class Building
    {
        
        protected int x;                                //Position X de la batiment
        protected int y;                                //Position Y de la batiment
        protected int depth;                            //Profondeur de la batiment
        protected int width;                            //Largeur de la batiment
        protected string color;                         //Couleur de la batiment   
        private List<Box> boxes;                        //Liste des boxes de la batiment
        public int frameCounter = 0;                    //Compteur des frames

        //Attribution de X de la batiment
        public int setBuildingXPosition
        {
            set
            {
                x = value;
            }
        }
        //Attribution de Y de la batiment
        public int setBuildingYPosition
        {
            set { y = value; }
        }
        //Attribution du profondeur de la batiment
        public int getsetDepth {
        get { return depth; }
            set { depth = value; }
        }
        //Attribution du largeur de la batiment
        public int getsetWidth
        {
            get { return width; }
            set { width = value; }
        }
        //Render de la batiment
        public abstract void Render(BufferedGraphics drawingSpace);
    }
    public partial class ZavodRoshen : Building
    {
        private float _powerConsumption;
        public int Id { get; private set; }
        public ZavodRoshen(int powerConsumption, int x, int y, int depth, int width, int id) : base() 
        {
            this._powerConsumption = powerConsumption;
            this.Id = id;
            this.x = x;
            this.y = y;
            this.depth = depth;
                this.width = width;
            Console.WriteLine("L'usine consomme " + powerConsumption + " KwH");
        }
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildingBrush, new Rectangle(x, y, width, depth));
        }
        public void Update(int interval)
        {
            int compteur = 0;
            compteur++;
             frameCounter += interval;

    if (frameCounter >= 5000) // 5 secondes
    {
        frameCounter = 0;

        int poids = RandomNumberHelper.Get(5, 11); 
        string[] couleurs = { "Rouge", "Jaune", "Bleu", "Brun", "Orange" };
                Random rnd = new Random();
                string couleur = couleurs[rnd.Next(couleurs.Length)];

                Box box = new Box(poids, couleur);

        Console.WriteLine($"[Factory {Id}] Production : {box}");

      
        AirSpace.DispatchCenter.AddBox(box);
    }
        }

    }
    public partial class ATB : Building
    {
        private string _openingHours;
        public ATB(string openingHours, int x, int y, int depth, int width) : base()
        {
            _openingHours = openingHours;
            Console.WriteLine("Nous sommes ouverts : " + openingHours);
            this.x = x;
            this.y = y;
            this.depth = depth;
            this.width = width;
        }
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(buildingBrush, new Rectangle(x, y, width, width));
        }
    }
}
