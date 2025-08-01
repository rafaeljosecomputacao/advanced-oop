using System;
using Posts.Extensions;

namespace Posts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = new DateTime(2025, 07, 31, 10, 30, 20);
            string sentence = "Good morning dear friends";
            
            Console.WriteLine(sentence.Cut(20) + " " + moment.ElapsedTime());
        }
    }
}
