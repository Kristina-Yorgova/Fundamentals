using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
