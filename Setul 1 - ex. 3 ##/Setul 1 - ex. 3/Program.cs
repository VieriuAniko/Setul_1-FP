using System;

namespace Setul_1___ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            int n, k;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}.");
            else
                Console.WriteLine($"{n} nu se divide cu {k}.");
        }
    }
}
