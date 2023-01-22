using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char char1 = char.Parse(Console.ReadLine());


            if (char1 > 96)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
