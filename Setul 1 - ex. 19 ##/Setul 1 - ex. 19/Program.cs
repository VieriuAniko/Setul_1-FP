using System;
using System.Linq;

namespace Setul_1___ex._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.

            int n;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            string strN = n.ToString();

            bool isTwoDigitRepeating = strN.All(c => c == strN[0] || c == strN[1]);

            if (isTwoDigitRepeating && strN.Length > 1)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

        }
    }
}

