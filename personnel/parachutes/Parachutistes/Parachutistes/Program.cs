using System;
using System.Security.Cryptography.X509Certificates;
using Parachutistes;
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
        ConsoleKeyInfo keyPressed;
        List<Para> parachutistsInTheAir = new List<Para>();
        Plane plane = new Plane(0, 0);
          plane.board(new Para("Bob"));
        Console.CursorVisible = false;
        while (true)
        {
           
            plane.draw();
            plane.update();
           
        }
 
    }



   
   
}
