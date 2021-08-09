using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 10000000; i++)
            {
                for (int j = 2; j < i; j++) 
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2))
                {
                    Console.Write(i + "\t");
                }

                count = 0;
            }
        }
    }
}
