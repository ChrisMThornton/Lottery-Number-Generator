using System;
using System.Collections.Generic;
using System.Linq;

namespace LotteryNumberGenerator.Services
{
    public class LotteryService
    {
        private static Random _random;

        static LotteryService()
        {
            _random = new Random();
        }

        public int[] GenerateLotteryNumbers(bool includeBonusBall)
        {
            var numbers = new HashSet<int>(); //use hashset to ensure unique numbers
            var numberRequired = includeBonusBall ? 7 : 6;

            while (numbers.Count < numberRequired)
            {
                var next = _random.Next(1, 49);
                numbers.Add(next);
            }

            return numbers.OrderBy(i => i).ToArray();
        }
    }
}
