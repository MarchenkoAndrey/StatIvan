using System;
using System.Collections.Generic;

namespace StatIvan
{
    public static class PrintResult
    {
        public static void PrintTable(Table1 table1)
        {
            PrintRow(table1.Ii);
            PrintRow(table1.Ni);
            PrintRow(table1.Wi);
            PrintRow(table1.Bi);
            PrintRow(table1.Xi);
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

        public static void PrintData(Part2 part2)
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
    }
}
