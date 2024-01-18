using System;

namespace Setul_1___ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Afisati toti divizorii numarului n. 

            int n, i;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Divizorii lui {n} sunt: ");

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} ");
            }
        }
    }
}
