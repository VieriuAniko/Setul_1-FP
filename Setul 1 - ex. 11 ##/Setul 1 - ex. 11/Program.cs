using System;

namespace Setul_1___ex._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Afisati in ordine inversa cifrele unui numar n.

            int n, c;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cifrele numarului {n} afisate in ordine inversa sunt: ");

            while(n != 0)
            {
                c = n % 10;

                Console.Write($"{c} ");

                n /= 10;
            }
        }
    }
}
