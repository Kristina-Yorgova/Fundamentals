using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starting = int.Parse(Console.ReadLine());

            int yield = starting;
            int totalSpices = 0;
            int spices = starting;
            int daysCount = 0;


            if (yield < 100)
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpices);

            }
            else
            {
                while (yield >= 100)
                {
                    daysCount++;
                    spices = yield;
                    spices -= 26;
                    yield -= 10;
                    totalSpices += spices;
                }
                totalSpices -= 26;

                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpices);
            }
        }

    }
}
