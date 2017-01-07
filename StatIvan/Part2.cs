using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatIvan
{
    public class Part2
    {
        public double M1;
        public double M2;
        public double M3;
        public double M4;
        
        public double m2;
        public double m3;
        public double m4;

        public double Xв;
        public double Dв;
        public double Бв;
        public double As;
        public double Ex;
        public double V;

        public Part2(Table1 table1)
        {
            for (var index = 0; index < table1.k; ++index)
            {
                M1 += table1.Xi[index] * table1.Wi[index];
                M2 += Math.Pow(table1.Xi[index], 2) * table1.Wi[index];
                M3 += Math.Pow(table1.Xi[index], 3) * table1.Wi[index];
                M4 += Math.Pow(table1.Xi[index], 4) * table1.Wi[index];
            }

            m2 = M2 - Math.Pow(M1, 2);
            m3 = M3 - 3 * M2 * M1 + 2 * Math.Pow(M1, 3);
            m4 = M4 - 4 * M3 * M1 + 6 * M2 * Math.Pow(M1, 2) - 3 * Math.Pow(M1, 4);

            Xв = M1;
            Dв = m2;
            Бв = Math.Sqrt(Dв);
            As = m3/Math.Pow(Бв, 3);
            Ex = m4/Math.Pow(Бв, 4) - 3;
            V = Бв/Xв;
        }
    }
}
