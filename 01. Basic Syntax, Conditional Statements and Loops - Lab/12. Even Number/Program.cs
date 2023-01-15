using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 0) num = Math.Abs(num);
                if (num % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
            }

        }
            
    }
}
