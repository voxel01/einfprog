using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1O3
{
    class t1o3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seite A");
            double a = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine("Seite B");
            double b = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("Umfang: " + (2 * (a + b)));
            Console.WriteLine("Fläche: " + (a * b));
        }
    }
}
