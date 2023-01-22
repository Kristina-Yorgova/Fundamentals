using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbols = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= symbols; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine("The sum equals: "+sum);
        }
    }
}
