namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(Console.WindowWidth / 2 - "Eddigi megoldások:".Length/2, 1);
            Console.WriteLine($"Eddigi megoldások:");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDay 1:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   First  : " );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day1.Program.first());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   Second : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day1.Program.second());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDay 2:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   First  : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day2.Program.first());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   Second : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day2.Program.second());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDay 3:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   First  : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day3.Program.first());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   Second : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day3.Program.second());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDay 4:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   First  : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day4.Program.day(false));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t   Second : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day4.Program.day(true));
        }
    }
}
