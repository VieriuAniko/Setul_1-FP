using System;

namespace Setul_1___ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 

            int a, b, aux;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valorile initiale ale lui a si b sunt {a}, respectiv {b}.");

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Valorile modificate ale lui a si b sunt {a}, respectiv {b}.");
        }
    }
}
