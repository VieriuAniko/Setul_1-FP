using System;

namespace Setul_1___ex._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

            int a, b, aInitial, bInitial;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b =");
            b = int.Parse(Console.ReadLine());

            aInitial = a;
            bInitial = b;

            while (a != b)
                if (a > b)
                    a -= b;
                else
                    b -= a;

            int cmmdc = a;

            Console.WriteLine($"Cmmdc dintre {aInitial} si {bInitial} este {a}.");

            a = aInitial;
            b = bInitial;

            int cmmmc = a * b / cmmdc;

            Console.WriteLine($"Cmmmc numerelor {aInitial} si {bInitial} este {cmmmc}.");
        }
    }
}
