using System;
using System.Linq;

namespace StatIvan
{
    public class Table1
    {
        public string[] Ii;
        public int[] Ni;
        public double[] Wi;
        public double[] Bi;
        public double[] Xi;
        
        public int StartInterval;
        public int FinishInterval;
        public int LengthInterval;
        public int k;
        public int h;



        public Table1(double[] data)
        {
            StartInterval = (int)Math.Round(data.Min());
            FinishInterval = (int)Math.Round(data.Max());
            LengthInterval = FinishInterval - StartInterval;

            k = 0;
            for (var choiseK = 8; choiseK <= 10; ++choiseK)
            {
                if (LengthInterval % choiseK != 0) continue;
                k = choiseK;
                break;
            }

            h = LengthInterval / k;
            
            Ii = new string[k];
            Ni = new int[k];
            Wi = new double[k];
            Bi = new double[k];
            Xi = new double[k];

            for (var index = 0; index < k; index++)
            {
                Ii[index] = string.Format(index*h + "-" + (index + 1)*h);
                Ni[index] = data.Where(a => a >= index*h && a <= (index + 1)*h).Count();
                Wi[index] = (double)Ni[index]/data.Length;
                Bi[index] = Wi[index]/h;
                Xi[index] = (index*h + (index + 1)*h)/2.0;
            }
        }
    }    
}
