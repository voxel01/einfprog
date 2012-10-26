using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1A2
{
    class t1a2
    {
        static void Main(string[] args)
        {
            Array.Reverse(args);
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
