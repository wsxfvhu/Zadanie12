using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static class Circle
        {
            public static double LengthCircle(int r0)
            {
                double l = 2 * Math.PI * r0;
                return l;
            }
            public static double SquareCircle(int r0)
            {
                double s = Math.PI * r0 * r0;
                return s;
            }
            public static bool AffiliationCircle(int x, int y, int r0, int x0 = 0, int y0 = 0)
            {
                bool affiliation = false;
                double r = Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2));
                if (r <= r0)
                {
                    affiliation = true;
                }
                return affiliation;
            }
        }
    }
}
