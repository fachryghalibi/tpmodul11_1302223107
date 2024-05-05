// class1.cs (AljabarLibraries)
using System;

namespace AljabarLibraries
{
    public static class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                // Akar imajiner, return null
                return null;
            }
            else if (discriminant == 0)
            {
                // Akar ganda
                double root = -b / (2 * a);
                return new double[] { root, root };
            }
            else
            {
                // Dua akar berbeda
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double aSquared = a * a;
            double bSquared = b * b;
            double abTimes2 = 2 * a * b;

            return new double[] { aSquared, abTimes2, bSquared };
        }
    }
}
