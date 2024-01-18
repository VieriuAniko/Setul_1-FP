using System;

namespace Setul_1___ex._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se dau 3 numere. Sa se afiseze in ordine crescatoare. 

            int a, b, c;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            Console.Write($"Cele trei numere afisate in ordine crescatoare sunt: ");

            if (a < b && a < c && b < c)
                Console.Write($"{a}, {b} si {c}.");
            else
                if (a < c && a < b && c < b)
                    Console.Write($"{a}, {c} si {b}.");
                else
                    if (b < a && b < c && a < c)
                        Console.Write($"{b}, {a} si {c}.");
                    else
                        if (b < c && b < a && c < a)
                            Console.Write($"{b}, {a} si {c}.");
                        else
                            if (c < a && c < b && a < b)
                                Console.Write($"{b}, {a} si {c}.");
                            else
                                Console.Write($"{c}, {b} si {a}.");
            
        }
    }
}
