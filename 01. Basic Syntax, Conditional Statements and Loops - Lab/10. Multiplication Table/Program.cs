﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }

        }
    }
}
