using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1I3
{
    class t1i3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben sie den Einkaufswert ein:");
            double wert = Convert.ToDouble(Console.ReadLine().Trim());
            int rabatt = 0;
            if (wert >= 500) rabatt = 20;
            else if (wert >= 300) rabatt = 14;
            else if (wert >= 200) rabatt = 8;
            else if (wert >= 100) rabatt = 3;

            Console.WriteLine("Rabat: " + rabatt + "%");
        }
    }
}
