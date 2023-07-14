using static System.Console;
using static Yann.wc;

namespace würfel_bullshit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Würfel w = new Würfel(5);
            Würfel w2 = new Würfel(9);
            for (int i = 0; i < 10; i++)
            {
                w.Würfeln();
                w2.Würfeln();
                if (w.Augenzahl == w2.Augenzahl)
                {
                    WriteLineColor($"Würfel 1: <*green*>{w.Augenzahl}<*/*>  Würfel 2: <*green*>{w2.Augenzahl}<*/*>");
                }
                else
                {
                    WriteLineColor($"Würfel 1: <*red*>{w.Augenzahl}<*/*>  Würfel 2: <*red*>{w2.Augenzahl}<*/*>");
                }
            }
            ReadKey();
        }

        static void Test()
        {
            //
            // This program demonstrates all colors and backgrounds.
            //
            Type type = typeof(ConsoleColor);
            ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }
            BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }

            //
            // This is an example to show you how to you WriteColor or WriteLineColor
            //
            WriteLineColor("\nYou can see all possible colors above!\nThis is an example string for <*!red*>background color<*/!*> and <*red*>foreground color<*/*>.");
        }
    }
}