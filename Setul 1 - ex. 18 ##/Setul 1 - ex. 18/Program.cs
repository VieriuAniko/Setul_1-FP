using System;

namespace Setul_1___ex._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.

            int n;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int d = 2, p;

            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p != 0)
                {
                    Console.Write($"{d}^{p}");

                    if (n > 1)
                        Console.Write(" * ");
                }
                d++;

                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
        }
    }
}
