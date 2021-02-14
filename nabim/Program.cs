using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nabim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Discord Nitro Generator\n");
            Console.Write("coded by mert shy");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < int.MaxValue; i++)
            {
            Console.Write("discord.gift/");
            Console.WriteLine(GetLetters(24));
            System.Threading.Thread.Sleep(100);
            }
        }
        public static string GetLetters(int numberOfCharsToGenerate)
        {
            var random = new Random();
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            var sb = new StringBuilder();
            for (int i = 0; i < numberOfCharsToGenerate; i++)
            {
                int num = random.Next(0, chars.Length);
                sb.Append(chars[num]);
            }
            return sb.ToString();
        }
    }
}
