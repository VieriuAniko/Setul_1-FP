using System;

namespace Setul_1___ex._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati cati ani bisecti sunt intre anii y1 si y2.

            int y1, y2, i, nr = 0;

            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());

            for (i = y1 + 1; i < y2; i++)
            {
                if (DateTime.IsLeapYear(i))
                    nr++;
            }

            Console.WriteLine($"Exista {nr} ani bisecti intre anii {y1} si {y2}.");
        }
    }
}
