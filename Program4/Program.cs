using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i< 1000; i++)
            {
                for(var f= 0; f < i; f++)
                {
                    Console.Write("1");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
