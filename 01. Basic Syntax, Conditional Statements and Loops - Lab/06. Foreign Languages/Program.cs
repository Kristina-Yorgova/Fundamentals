using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "";

            switch (country)
            {
                case "England":
                case "USA":
                    language = "English"; break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";break;
                default: language = "unknown";break;
            }
            Console.WriteLine(language);

        }
    }
}
