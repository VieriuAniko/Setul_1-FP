using System;

namespace Setul_1___ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 

            int a, b;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valorile initiale ale lui a si b sunt {a}, respectiv {b}.");

            (a, b) = (b, a);

            Console.WriteLine($"Valorile modificate ale lui a si b sunt {a}, respectiv {b}.");
        }
    }
}
