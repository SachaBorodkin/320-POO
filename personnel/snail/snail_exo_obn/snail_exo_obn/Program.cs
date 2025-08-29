int snailHP = 50;

int startPositionLeft = 0;
int startPositionTop = 10;
Console.SetCursorPosition(startPositionLeft, startPositionTop);
Console.ForegroundColor = ConsoleColor.Blue;
for (int i = snailHP; i >= 0; i--)
{
    Console.Clear();
    
   

    startPositionLeft += 1;
    Console.SetCursorPosition(startPositionLeft, startPositionTop);
    Console.Write("_@_ö");
    Thread.Sleep(200);
    if (i == 0)
    {
        Console.Clear();
        Console.SetCursorPosition(startPositionLeft, startPositionTop);
        Console.Write("____");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
