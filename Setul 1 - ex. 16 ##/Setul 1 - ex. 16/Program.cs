using System;
using System.Collections.Generic;

namespace Setul_1___ex._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            int nr1, nr2, nr3, nr4, nr5;

            Console.Write("nr1 = ");
            nr1 = int.Parse(Console.ReadLine());

            Console.Write("nr2 = ");
            nr2 = int.Parse(Console.ReadLine());

            Console.Write("nr3 = ");
            nr3 = int.Parse(Console.ReadLine());

            Console.Write("nr4 = ");
            nr4 = int.Parse(Console.ReadLine());

            Console.Write("nr5 = ");
            nr5 = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>(5);

            numbers.Add(nr1);
            numbers.Add(nr2);
            numbers.Add(nr3);
            numbers.Add(nr4);
            numbers.Add(nr5);

            Console.Write("Numerele din sir sunt: ");
            foreach (int a in numbers)
                Console.Write(a + " ");
            //Console.WriteLine();

            numbers.Sort();

            Console.WriteLine();

            Console.Write("Numerele ordonate crescator din sir sunt: ");
            foreach (int a in numbers)
                Console.Write(a + " ");
        }

        
    }
}
