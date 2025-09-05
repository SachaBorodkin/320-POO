using System;
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

     
    }
}