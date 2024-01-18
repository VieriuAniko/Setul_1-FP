using System;

namespace Setul_1___ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.

            float a, b, x;

            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());

            //ax + b = 0
            //ax = -b
            x = -b / a;

            Console.Write($"{x}");
        }
    }
}
