﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Print_and_sum
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.Write(i + " ");
                sum += i;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}