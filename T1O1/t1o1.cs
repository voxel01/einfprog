using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class t1o1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Anzahl der Scheine");
                short anzahl = Convert.ToInt16(Console.ReadLine().Trim());
                Console.WriteLine("Preis");
                double preis = Convert.ToDouble(Console.ReadLine().Trim());
                Console.WriteLine("Prozente");
                double prozente = Convert.ToDouble(Console.ReadLine().Trim());

                double preisPro = preis / 100 * (100 - prozente);

                Console.WriteLine("Einzelpreis: " + preisPro);
                Console.WriteLine("Summe: " + (preisPro * anzahl));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
