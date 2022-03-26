using System;

namespace _5x5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0,5}", i * 1);
                Console.Write("{0,5}", i * 2);
                Console.Write("{0,5}", i * 3);
                Console.Write("{0,5}", i * 4);
                Console.Write("{0,5}", i * 5);
                Console.WriteLine();
            }
        }
    }
}
