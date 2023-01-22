using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCount = 0;
            double percent = (double) pokePower * 0.5;


            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetCount++;

                if (pokePower == percent && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;

                }

                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);


        }
    }
}
