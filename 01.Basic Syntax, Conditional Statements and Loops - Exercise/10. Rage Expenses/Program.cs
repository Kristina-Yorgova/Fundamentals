using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int game = 1; game <= lostGames; game++)
            {
                if (game % 2 == 0) trashedHeadset++;
                if (game % 3 == 0) trashedMouse++;
                if (game %6 ==0) trashedKeyboard++;
                if (game % 6 == 0 && trashedKeyboard % 2 ==0) trashedDisplay++;
            }


            double totalExpenses = (trashedHeadset * headsetPrice) + (trashedMouse * mousePrice) + (trashedKeyboard * keyboardPrice) + (trashedDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");



        }
    }
}
