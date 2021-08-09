using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[1];
            args[0] = "deleveled";
           foreach (var arg in args)
            {
                var reverseChar = Reverse(arg);
                if(arg == reverseChar)
                {
                    Console.WriteLine($"{arg} Is Same");
                }
                else
                {
                    Console.WriteLine($"{arg} Is not Same");
                }
            }
        }

        private static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
