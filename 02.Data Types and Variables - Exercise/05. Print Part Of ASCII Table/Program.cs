using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= secondChar; i++)
            {
                char currentChar = (char)i;
                Console.Write(currentChar + " ");
            }
        }
    }
}
