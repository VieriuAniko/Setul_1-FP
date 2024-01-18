using System;
using System.Collections.Generic;

namespace Setul_1___ex._20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).

            ///<example> 13/30 = 0.4(3) </example>

            /*
            Precizari:
            ---> O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
            ---> O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
            ---> O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
            */

            Console.Write("Introduceti numaratorul fractiei:");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numitorul fractiei:");
            int n = int.Parse(Console.ReadLine());

            int parteIntreaga = m / n;
            int parteFractionara = m % n;
            Console.Write($"{parteIntreaga},");

            int cifra, rest;

            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();

            resturi.Add(parteFractionara);

            bool periodic = false;

            do
            {
                cifra = parteFractionara * 10 / n;
                cifre.Add(cifra);

                rest = parteFractionara * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFractionara = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
    }
}
