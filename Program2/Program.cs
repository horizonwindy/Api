using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int round = 100;
            double n = 1;
            for (int i = round; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine(n);

        }
    }
}
