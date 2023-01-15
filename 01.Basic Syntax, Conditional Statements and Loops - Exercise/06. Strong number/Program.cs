using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int numCopy = number;
            int factorialSum = 0;
            while (numCopy >0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;

                }
                factorialSum += factorial;

            }
            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
