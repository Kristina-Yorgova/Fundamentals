using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int beerKegs = int.Parse(Console.ReadLine());
            double volume = 0;
            string biggest = string.Empty;

            for (int i = 0; i < beerKegs; i++)
            {
                
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfKeg = Math.PI * radius * radius * height;
                
                if (volumeOfKeg > volume)
                {
                    biggest = model;
                    volume = volumeOfKeg;
                }

              
                
            }
            Console.WriteLine(biggest);
        }
    }
}
