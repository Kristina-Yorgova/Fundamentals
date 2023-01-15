using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string user = Console.ReadLine();

            int counter = 0;


           string correctPassword = new string(user.Reverse().ToArray());

            while (true)
            {
                string password = Console.ReadLine();

                if (password != correctPassword)
                {
                    
                    counter++;

                    if (counter > 3)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password == correctPassword)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
            }
            


        }
    }
}
