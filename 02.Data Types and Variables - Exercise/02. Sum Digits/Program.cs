using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = number;
            int sum = 0;

            while (currentNumber > 0)
            {
                int lastDiggit = currentNumber % 10;
                currentNumber /= 10;                
                sum+=lastDiggit;
                

            }
            Console.WriteLine(sum);

            
        }
    }
}
