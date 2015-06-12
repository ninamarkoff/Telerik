using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Common
{
    public class RandomGenerator : TicketSystem.Common.IRandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public string RandomString(int minLength, int maxLength)
        {
            var result = new StringBuilder();
            var length = this.random.Next(minLength, maxLength + 1);
            for (int i = minLength; i < maxLength; i++)
            {
                result.Append(Letters[this.random.Next(0, Letters.Length)]);
            }

            return result.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }
    }
}
