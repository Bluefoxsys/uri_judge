﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior número é " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("O maior número é " + n2);
            }
            else
            {
                Console.WriteLine("O maior número é " + n3);
            }

        }
    }
}
