using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2K2
{
    class t2k2
    {
        static void Main(string[] args)
        {
            Uhrzeit t1 = new Uhrzeit(3, 2, 1);
            Uhrzeit t2 = new Uhrzeit(5, 4, 3);

            int hh, mm, ss;
            t1.Diff(t2, out hh, out mm, out ss);

            Console.WriteLine("Differenz zwischen t1 und t1 sind {0} Stunden, {1} Minuten und {2} Sekunden", hh, mm, ss);

        }
    }
}
