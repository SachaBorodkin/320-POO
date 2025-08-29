Snail snail = new Snail();
snail.move();
class Snail
{
    public string _snailAlive = "_@_ö";
    public string _snailDead = "____";
    public int _snailHP = 50;

    public int _snailPositionleft = 0;
    public int _snailPositionTop = 10;

    public void move()
    {
        Console.SetCursorPosition(_snailPositionleft, _snailPositionTop);
       
        for (int i = _snailHP; i >= 0; i--)
        {
           
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            if (randomNumber == 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (randomNumber == 2)
                Console.ForegroundColor = ConsoleColor.DarkGray;
            else if (randomNumber == 3)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (randomNumber == 4)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (randomNumber == 5)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (randomNumber == 6)
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (randomNumber == 7)
                Console.ForegroundColor = ConsoleColor.DarkMagenta;


            Console.Clear();
            
            _snailPositionleft += 1;
            Console.SetCursorPosition(_snailPositionleft, _snailPositionTop);
            if (i > 0)
                Console.Write(_snailAlive);
            else
                Console.Write(_snailDead);
            Thread.Sleep(200);

        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}
