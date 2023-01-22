using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {

                    for (int k = 0; k < number; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdchar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdchar}");
                    }
                }
            }

        }
    }
}
