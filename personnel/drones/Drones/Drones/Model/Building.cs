using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Drones
{
    public partial class Building
    {
        
        protected int x;
        protected int y;
        protected int depth;
        protected int width;
        protected string color;
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
    }
    public partial class ZavodRoshen : Building
    {
        private float _powerConsumption;
        public ZavodRoshen(int powerConsumption, int x, int y, int depth, int width) : base() 
        {
        _powerConsumption = powerConsumption;
            this.x = x;
            this.y = y;
            this.depth = depth;
                this.width = width;
            Console.WriteLine("L'usine consume " + powerConsumption + " KwH");
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
    }
}
