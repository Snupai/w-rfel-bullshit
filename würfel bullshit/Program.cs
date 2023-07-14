using System.Diagnostics.CodeAnalysis;
using static System.Console;
using static Yann.wc;

namespace würfel_bullshit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int anzahlWürfe = 10_000_000;
            int anzahlWürfel = 5;
            List<Würfel> würfels = new();
            for (int i = 0; i < anzahlWürfel; i++)
            {
                würfels.Add(new Würfel());
            }
            foreach (var item in würfels)
            {
                int wurf = item.Würfeln();
                WriteLine(wurf);
                sum += wurf;
            }
            WriteLine($"Summe: {sum}\n");

            List<int> augen = new();
            for (int i = 0; i < anzahlWürfe; i++)
            {
                foreach (var item in würfels)
                {
                    augen.Add(item.Würfeln());
                }
            }
            Häufigkeit(augen, anzahlWürfe, anzahlWürfel);
            ReadKey();
        }

        static void Häufigkeit(List<int> augen, int anzahlWürfe, int anzahlWürfel)
        {
            int sum = 0;
            int[] häufigkeit = new int[7];
            double[] häufigkeitProzent = new double[7];
            foreach (var item in augen)
            {
                häufigkeit[item]++;
            }
            for (int i = 1; i < häufigkeit.Length; i++)
            {
                WriteLine($"{i}: {100.0/ (anzahlWürfe* anzahlWürfel) * häufigkeit[i]:N2}%");
                häufigkeitProzent[i] = 100.0 / (anzahlWürfe * anzahlWürfel) * häufigkeit[i];
            }
            //TODO create histogram


            foreach (var auge in augen)
            {
                sum += auge;
            }
            WriteLine($"Summe: {sum:N0}");
            
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