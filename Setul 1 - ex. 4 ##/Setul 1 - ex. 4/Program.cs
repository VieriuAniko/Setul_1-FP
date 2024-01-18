using System;

namespace Setul_1___ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati daca un an y este an bisect. 

            int y;

            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(y))
            {
                Console.WriteLine($"Anul {y} este an bisect.");
            }
            else
            {
                Console.WriteLine($"Anul {y} nu este an bisect.");
            }
        }
    }
}
