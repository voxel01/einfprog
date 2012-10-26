using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1L2
{
    class t1l2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben sie die Zahl ein deren Fakultät errechnet werden soll");
                int zahl = Convert.ToInt32(Console.ReadLine().Trim());
                if (zahl <= 0)
                {
                    t1l2.fehler("Division durch 0 nicht möglich");
                }
                else
                {
                    long fa = 1;
                    for (int wert = zahl;wert > 0; wert --)
                    {
                        if (fa > Int64.MaxValue / 2 && wert > 2)
                        {
                            t1l2.fehler("Wert zu groß um ihn mit Int 64 darzusetellen");
                            return;
                        }
                        fa *= wert;
                    }
                    Console.WriteLine("Fakultät n! =  " + (fa));
                }
            }
            catch (Exception e)
            {
                t1l2.fehler(e.Message);
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
