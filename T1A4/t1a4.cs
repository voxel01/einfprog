using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1A4
{
    class t1a4
    {
        static void Main(string[] args)
        {
            int[] fib = new int[30];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.WriteLine(fib.Length+" Fibonacci Zahlen:");
            for (int i = 0; i < fib.Length; i++)
            {

                Console.WriteLine(fib[i]);
            }
        }
    }
}
