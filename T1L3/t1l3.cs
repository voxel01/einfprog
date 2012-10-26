using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1L3
{
    class t1l3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32(Console.ReadLine().Trim());

            while (zahl1 > 0 && zahl2 > 0)
            {
                if (zahl1 > zahl2)
                {
                    zahl1 -= zahl2;
                }
                else
                {
                    zahl2 -= zahl1;
                }
            }
            if (zahl1 > zahl2)
            {
                Console.WriteLine("GGT = " + zahl1);
            }
            else
            {
                Console.WriteLine("GGT = " + zahl2);
            }
        }
    }
}
