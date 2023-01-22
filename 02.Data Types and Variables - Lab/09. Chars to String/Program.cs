using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());


            Console.WriteLine($"{char1}{char2}{char3}");
        }
    }
}
