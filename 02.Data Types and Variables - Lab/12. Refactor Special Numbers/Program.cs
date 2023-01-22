using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)

            {

                int currentNumber = i;
                int sum = 0;

                while (currentNumber > 0)

                {
                    sum += currentNumber % 10;

                    currentNumber /= 10;

                }

                bool isSpecial = false;

                if (sum == 5 || sum == 7 || sum == 11) isSpecial = true;
                
                Console.WriteLine("{0} -> {1}", i, isSpecial);

            }
        }
    }
}
