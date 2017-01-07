using System;
using System.Collections.Generic;

namespace StatIvan
{
    public static class PrintResult
    {
        public static void PrintPart1(Part1 part1)
        {
            PrintRow(part1.Ii);
            PrintRow(part1.Ni);
            PrintRow(part1.Wi);
            PrintRow(part1.Bi);
            PrintRow(part1.Xi);
            Console.WriteLine();
        }

        private static void PrintRow<T>(IEnumerable<T> data)
        {
            foreach (var i in data)
            {
                Console.Write("{0,7} ", i);
            }
            Console.WriteLine();
        }

        public static void PrintPart2(Part2 part2)
        {
            Console.WriteLine("M1: {0}", part2.M1);
            Console.WriteLine("M2: {0}", part2.M2);
            Console.WriteLine("M3: {0}", part2.M3);
            Console.WriteLine("M4: {0}", part2.M4);
            Console.WriteLine("m2: {0}", part2.m2);
            Console.WriteLine("m3: {0}", part2.m3);
            Console.WriteLine("m4: {0}", part2.m4);
            Console.WriteLine("Xв: {0}", part2.Xв);
            Console.WriteLine("Dв: {0}", part2.Dв);
            Console.WriteLine("Бв: {0}", part2.Бв);
            Console.WriteLine("As: {0}", part2.As);
            Console.WriteLine("Ex: {0}", part2.Ex);
            Console.WriteLine("V:  {0}", part2.V);
            Console.WriteLine();
        }

        public static void PrintPart3(Part1 part1, Part3 part3)
        {
            for (var i = 0; i < part1.k; ++i)
            {
                PrintRowTrans(part3, i);
            }
            Console.WriteLine("X2набл: {0}",part3.X2набл);
            Console.WriteLine();
        }

        private static void PrintRowTrans(Part3 part3, int index)
        {
            Console.Write("{0,3}", part3.Xi[index]);
            Console.Write("{0,3}", part3.Xi1[index]);
            Console.Write("{0,3}", part3.ni[index]);
            Console.Write("{0,7}", part3.zi[index]);
            Console.Write("{0,7}", part3.zi1[index]);
            Console.Write("{0,7}", part3.E_zi[index]);
            Console.Write("{0,7}", part3.E_zi1[index]);
            Console.Write("{0,7}", part3.pi[index]);
            Console.Write("{0,7}", part3.npi[index]);
            Console.Write("{0,7}", part3.Component[index]);
            Console.WriteLine();
        }
    }
}