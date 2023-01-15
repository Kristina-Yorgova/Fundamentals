using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newHours = hours;
            int newMinutes = 0;

            newMinutes = minutes + 30;

            if (newMinutes > 59)
            {
                newHours = hours + 1;
                newMinutes %= 60;
            }
            if (newHours > 23) newHours = 0;

            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:{newMinutes:d2}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
            
        }
    }
}
