using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1I1
{
    class t1i1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben sie die Zahl ein deren Kehrwert errechnet werden soll");
                double zahl = Convert.ToDouble(Console.ReadLine().Trim());
                if (zahl == 0.0)
                {
                    t1i1.fehler("Division durch 0 nicht möglich");
                }
                else
                {
                    Console.WriteLine("Kehrwert: "+(1 / zahl));
                }
            }
            catch (Exception e)
            {
                t1i1.fehler(e.Message);
            }
        }
        public static void fehler(string msg)
        {
            Console.WriteLine("");
            Console.WriteLine("FEHLER: ");
            Console.WriteLine(msg);
        }
    }
}
