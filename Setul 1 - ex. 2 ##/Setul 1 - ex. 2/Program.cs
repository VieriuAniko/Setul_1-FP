using System;

namespace Setul_1___ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.

            double a, b, c, x1, x2, x, delta;

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            /*
            ax^2 + bx + c = 0 (toate cazurile posibile)

            delta = b^2 - 4ac


            Cazul 1: delta > 0

            x1 = (-b + sqrt(delta))/2a
            x2 = (-b - sqrt(delta))/2a

            Cazul 2: delta = 0

            x = (-b + sqrt(delta))/2a  sau  x = (-b - sqrt(delta))/2a

            Cazul 3: delta < 0

            x1 = (-b + i * sqrt(-delta))/2a
            x2 = (-b - i * sqrt(-delta))/2a
            */

            delta = (b * b) - (4 * a * c);

            if(delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}.");
            }
            else
            {
                if (delta == 0)
                {
                    x = (-b + Math.Sqrt(delta)) / 2 * a;

                    Console.WriteLine($"Solutia ecuatiei este {x}.");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(-delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(-delta)) / 2 * a;

                    Console.WriteLine($"Solutiile ecuatiei sunt {x1}i si {x2}i.");
                }

            }

        }
    }
}
