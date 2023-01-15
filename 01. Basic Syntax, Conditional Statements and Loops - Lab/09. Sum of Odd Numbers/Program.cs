using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int n1 = 1;

            for (int i = 1; i <= num; i++)
            {
                
                sum += n1;
                Console.WriteLine(n1);
                n1 += 2;
            }
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
