using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string product = string.Empty;
            double price = 0;
            double sum = 0;
            double coin = 0; 
            while ((input = Console.ReadLine()) != "Start")
            {
                coin = double.Parse(input);
                
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }
                 sum += coin;

               
            }
            if (input == "Start")
            {
                while ((product = Console.ReadLine()) != "End")
                {
                    if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                    {
                        Console.WriteLine("Invalid product");

                    }

                    switch (product)
                    {


                        case "Nuts":
                            price = 2.0;
                            if (sum < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            } 
                            else
                            {
                                Console.WriteLine("Purchased nuts");
                            }
                            sum -= price;
                            break;

                        case "Water":
                            price = 0.7;
                            if (sum < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased water");
                            }
                            sum -= price;
                            break;

                        case "Crisps":
                            price = 1.5;
                            if (sum < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased crisps");
                            }
                            sum -= price;
                            break;

                        case "Soda":
                            price = 0.8;
                            if (sum < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased soda");
                            }
                            sum -= price;
                            break;

                        case "Coke":
                            price = 1.0;
                            if (sum < price)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased coke");
                            }
                            sum -= price;
                            break;


                    }

                }

                Console.WriteLine($"Change: {sum:f2}");

            }

        }
    }
}
