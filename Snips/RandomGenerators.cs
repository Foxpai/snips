using System;
using System.Text;

namespace Snips
{
    internal class RandomGenerators
    {
        public void randomNumberGenerator()
        {
            //Generates a random number less than 32
            Random rnd = new();
            int num = rnd.Next(32);
            Console.WriteLine(num);

            StringBuilder rand = new();
            //generates 4 numbers less than 32 and appends them to a string
            for (int j = 0; j < 4; j++)
            {
                rand.Append(rnd.Next(32));
            }
        }
        public string randomPasswordGenerator(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&";
            StringBuilder res = new();
            Random rnd = new();
            while (16 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
