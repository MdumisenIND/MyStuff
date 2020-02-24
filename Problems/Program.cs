using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private string Prefix(string input)
        {
            if (input == null)
                return null;

            string len, numWords;

            len = input.Length + ",";
            numWords = input.Split(" ") + ":";

            return (len + numWords + input);
        }
    }    
}
