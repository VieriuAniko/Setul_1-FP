using System;

namespace Setul_1___ex._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

            int stanga = 1;
            int dreapta = 1024;
            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;
                Console.WriteLine($"Numarul este mai mare sau egal decat {mijloc}?");
                string raspuns = Console.ReadLine().ToLower();

                if (raspuns == "da")
                {
                    stanga = mijloc + 1;
                }
                else if (raspuns == "nu")
                {
                    dreapta = mijloc - 1;
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Va rugam sa raspundeti cu 'da' sau 'nu'.");
                }
            }

            Console.WriteLine($"Numarul ghicit este {dreapta}");
        }
    }
}
