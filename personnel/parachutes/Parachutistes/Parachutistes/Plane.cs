using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parachutistes;
namespace Parachutistes
{
    class Plane
    {
        private string[] view =
            {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        private int _startPositionX;
        private int _startPositionY;
        public List<Para> parachutists;
        public Plane(int startPositionX, int startPositionY)
        {
            this._startPositionX = startPositionX;
            this._startPositionY = startPositionY;
        }
        public Plane()
        {
            _startPositionX = 0;
            _startPositionY = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }
        public void draw()
        {


            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_startPositionX, i);
                Console.Write(view[i]);

            }

            Thread.Sleep(100);
            Console.Clear();
        }
        public void update()
        {
            _startPositionX ++;
        }
       public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = _startPositionX;
            parachutist.altitude = this._startPositionY;
            return parachutist;
        }
    }
}
