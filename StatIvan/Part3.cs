using System;
namespace StatIvan
{
    public class Part3
    {
        private double Lymbda;
        public int[] Xi;
        public int[] Xi1;
        public int[] ni;
        public double[] zi;
        public double[] zi1;
        public double[] E_zi;
        public double[] E_zi1;
        public double[] pi;
        public double[] npi;
        public double[] Component;
        public double X2набл;

        public Part3(Part1 table, Part2 data)
        {
            Lymbda = 1/data.Xв;

            Xi = new int[table.k];
            Xi1 = new int[table.k];
            ni = new int[table.k];
            zi = new double[table.k];
            zi1 = new double[table.k];
            E_zi = new double[table.k];
            E_zi1 = new double[table.k];
            pi = new double[table.k];
            npi = new double[table.k];
            Component = new double[table.k];
           
            for (var index = 0; index < table.k; index++)
            {
                Xi[index] = index * table.h;
                Xi1[index] = (index+1) * table.h;
                ni[index] = table.Ni[index];
                zi[index] = Math.Round(Lymbda * Xi[index],2);
                zi1[index] = Math.Round(Lymbda * Xi1[index],2);
                E_zi[index] = Math.Round(Math.Pow(Math.E,-zi[index]),4);
                E_zi1[index] = Math.Round(Math.Pow(Math.E, -zi1[index]),4);
                pi[index] = Math.Round(E_zi[index] - E_zi1[index], 4);
                npi[index] = Math.Round(pi[index] * table.Count,2);
                Component[index] = Math.Round(Math.Pow(ni[index] - npi[index], 2)/npi[index],3);
                X2набл += Math.Round(Component[index],2);
            }
        }
    }
}