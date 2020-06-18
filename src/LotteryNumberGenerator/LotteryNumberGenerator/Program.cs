using LotteryNumberGenerator.Services;
using System;

namespace LotteryNumberGenerator
{
    class Program
    {
        //Additional things to add later:
        //Unit tests for lottery number generation
        //option for user to choose with/without bonus ball (functionality for bonus ball already exists)

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the lottery number generator. Press any key to generate lottery numbers.");
            Console.ReadLine();
            var lotteryService = new LotteryService();
            var numbers = lotteryService.GenerateLotteryNumbers(false);

            Console.WriteLine("Your numbers");
            foreach (var number in numbers)
            {
                PresentNumber(number);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static void PresentNumber(int number)
        {
            Console.ForegroundColor = GetColour(number);
            Console.WriteLine(number);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static ConsoleColor GetColour(int number)
        {
            if (number >= 1 && number <= 9) return ConsoleColor.Gray;
            if (number >= 10 && number <= 19) return ConsoleColor.Blue;
            if (number >= 20 && number <= 29) return ConsoleColor.DarkRed; //Pink not available
            if (number >= 30 && number <= 39) return ConsoleColor.Green;
            if (number >= 40 && number <= 49) return ConsoleColor.Yellow;
            return ConsoleColor.White;
        }
    }
}
