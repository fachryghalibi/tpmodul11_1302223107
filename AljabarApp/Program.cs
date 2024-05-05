using System;
using AljabarLibraries;

namespace AljabarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan koefisien a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan koefisien b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan koefisien c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double[] koefisien = { a, b, c };

            double[] akar = Aljabar.AkarPersamaanKuadrat(koefisien);

            if (akar != null)
            {
                Console.WriteLine("Akar persamaan kuadrat:");
                foreach (double root in akar)
                {
                    Console.WriteLine(root);
                }
            }
            else
            {
                Console.WriteLine("Akar persamaan kuadrat adalah imajiner.");
            }
        }
    }
}
