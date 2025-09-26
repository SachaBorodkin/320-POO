using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Drones
{
    public abstract class Building
    {
        
        protected int x;
        protected int y;
        protected int depth;
        protected int width;
        protected string color;
        private List<Box> boxes;
        public int frameCounter = 0;
        public int setBuildingXPosition
        {
            set
            {
                x = value;
            }
        }
        public int setBuildingYPosition
        {
            set { y = value; }
        }
        public int getsetDepth {
        get { return depth; }
            set { depth = value; }
        }
        public int getsetWidth
        {
            get { return width; }
            set { width = value; }
        }
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
