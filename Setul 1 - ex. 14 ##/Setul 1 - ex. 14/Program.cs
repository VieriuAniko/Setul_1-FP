using System;

namespace Setul_1___ex._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.

            int x, ogl = 0, x1;

            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());

            x1 = x;

            while (x1 != 0)
            {
                ogl = ogl * 10 + x1 % 10;
                x1 /= 10;
            }

            if (x == ogl)
                Console.WriteLine($"Numarul {x} este palindrom.");
            else
                Console.WriteLine($"Numarul {x} nu este palindrom.");
        }
    }
}
