using System;

namespace Setul_1___ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

            int k, nr = 1, n, c, numar, ok = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            numar = n;

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            while (n > 9)
            {
                if (nr == k)
                {
                    c = n % 10;
                    Console.WriteLine($"A k-a cifra a numarului {numar} este {c}.");
                    ok = 1;
                    n /= 10;
                    nr++;
                }
                else
                {
                    n /= 10;
                    nr++;
                }
            }
            
            if (ok == 0)
            {
                c = n % 10;
                Console.WriteLine($"A k-a cifra a numarului {numar} este {c}.");
            }
        }
    }
}
