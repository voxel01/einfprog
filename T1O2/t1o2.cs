using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class t1o2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl");
            double zahl = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine("Zahl:" + zahl);
            Console.WriteLine("Ergebnis:" + Math.Pow(zahl, 2));
        }
    }
}
