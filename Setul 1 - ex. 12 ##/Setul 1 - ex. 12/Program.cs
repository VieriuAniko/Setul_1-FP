using System;

namespace Setul_1___ex._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].

            int n, a, b, nr = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;

            Console.WriteLine($"{nr} numere intregi sunt divizibile cu {n} si fac parte din intervalul [{a}, {b}].");
        }
    }
}
