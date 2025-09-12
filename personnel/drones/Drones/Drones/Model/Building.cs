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
        
        private int x;
        private int y;
        private int deepth;
        private int width;
        private string color;
        public int getBuildingXPosition
        {
            set
            {
                x = value;
            }
        }
        public int getBuildingYPosition
        {
            set { y = value; }
        }
        public int getDeepth {
        get { return deepth; }
            set { deepth = value; }
        }
        public int getWidth
        {
            get { return width; }
            set { width = value; }
        }
    }
   
}
