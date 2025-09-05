using System;
using System.Security.Cryptography.X509Certificates;
static class Config
{
    public const int SCREEN_HEIGHT = 40;
    public const int SCREEN_WIDTH = 150;
}

class Program
{

    static void Main()
    {

        Console.SetBufferSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);


        Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

        plane plane = new plane(0, 0); ;
        while (true)
        {
            plane.draw();
            plane.update();
           
        }
 
    }



    class plane
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
        public plane(int startPositionX, int startPositionY)
        {
            this._startPositionX = startPositionX;
            this._startPositionY = startPositionY;
        }

        public void draw()
        {

            
            for (int i = 0; i < view.Length; i++) {
                Console.SetCursorPosition(_startPositionX, i);
                Console.Write(view[i]);
                
            }
       
            Thread.Sleep(100);
            Console.Clear();
        }
        public void update()
        {
            _startPositionX += 1;
        }
    }

}
