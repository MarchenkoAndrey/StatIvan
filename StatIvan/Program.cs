using System;
using System.Linq;
using System.IO;

namespace StatIvan
{
    internal static class Program
    {
        private static void Main()
        {
            var data =
            File.ReadAllLines(
                        @"C:\Users\marchenko.a\Documents\Visual Studio 2012\Projects\StatIvan\StatIvan\Example.txt")
                        .SelectMany(z=>z.Split(' '))
                        .Select(double.Parse)
                        .ToArray();       
            Solution(data);
            Console.ReadKey();
        }

        private static void Solution(double[] data)
        {
            if (data.Length != 100)
            {
                Console.WriteLine("The sample must be a hundred items");
                return;
            }
            var table = new Part1(data);
            PrintResult.PrintPart1(table);

            var part2 = new Part2(table);
            PrintResult.PrintPart2(part2);

            var part3 = new Part3(table, part2);
            PrintResult.PrintPart3(table, part3);
        }
    }
}