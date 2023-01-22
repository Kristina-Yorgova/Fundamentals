using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //capacity = 255l;

            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int totalLitres = 0;


            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (litres <= capacity)
                {
                    totalLitres += litres;
                    capacity -= litres;
                }
                else Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(totalLitres);
        }
    }
}
