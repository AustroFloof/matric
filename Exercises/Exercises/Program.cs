Random rnd = new Random();
Console.ForegroundColor = ConsoleColor.DarkGreen;
for (int i = 0; i < 100000; i++)
{
    Console.Write(rnd.Next(0, 2) + "   ");
}