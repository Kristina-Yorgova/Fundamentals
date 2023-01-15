using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            decimal price = 0.0M;

            switch (group)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday": price = peopleCount * 8.45m; break;
                        case "Saturday": price = peopleCount * 9.80m; break;
                        case "Sunday": price = peopleCount * 10.46m; break;
                       
                    }
                    if (peopleCount >= 30) price *= 0.85m; 
                    break;
                case "Business":
                    if (peopleCount >= 100) peopleCount -= 10;
                    switch (day)
                    {

                        case "Friday": price = peopleCount * 10.90m; break;
                        case "Saturday": price = peopleCount * 15.60m; break;
                        case "Sunday": price = peopleCount * 16.0m; break;

                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday": price = peopleCount * 15.0m; break;
                        case "Saturday": price = peopleCount * 20.0m; break;
                        case "Sunday": price = peopleCount * 22.50m; break;

                    }
                    if (peopleCount >= 10 && peopleCount <=20) price *= 0.95m;
                    break;

                    
            }
            Console.WriteLine($"Total price: {price:f2}");





        }
    }
}
