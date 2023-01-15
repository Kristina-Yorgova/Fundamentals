using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //((daysInMonth * capsulesCount) * pricePerCapsule)

            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int order = 1; order <= orders; order++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                double pricePerOrder = ((days * capsules) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
                totalPrice += pricePerOrder;


                pricePerOrder = 0;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
