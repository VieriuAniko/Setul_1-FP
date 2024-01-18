using System;

namespace Setul_1___ex._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Test de primalitate: determinati daca un numar n este prim.

            int n, nrd = 0; //unde nrd - nr. de divizori

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    nrd++;
            }

            if (nrd == 2)
                Console.WriteLine($"Numarul {n} este prim.");
            else
                Console.WriteLine($"Numarul {n} nu este prim.");
        }
    }
}
