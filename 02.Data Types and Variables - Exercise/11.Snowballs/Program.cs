using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (currentSnowballValue > highestSnowballValue)
                {
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                    highestSnowballValue = currentSnowballValue;
                }


            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestSnowballValue} ({highestQuality})");
        }
    }
}
