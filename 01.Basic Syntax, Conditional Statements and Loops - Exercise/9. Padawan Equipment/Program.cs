using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double priceLightsaber = lightsaber * (Math.Ceiling(students * 1.1));
            double priceRobe = robe * students;
            int freeBelts = students / 6;
            double priceBelts = belts * (students - freeBelts);
            double totalPrice = priceLightsaber + priceRobe + priceBelts;


            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }






        }
    }
}
