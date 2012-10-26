using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto20121026
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankkonto kto1 = new Bankkonto("Max Mustermann", 1000.0, 10.0);
            Konto kto2 = new Konto("Tester", 2000.0);

            kto2.Zinssatz = 15.0;

            kto1.ausgabe();
            kto2.ausgabe();

            Console.WriteLine("Vergebe die Zinsen für die Konten");
            kto1.zinsenBerechnen();
            kto2.zinsenBerechnen();

            kto1.ausgabe();
            kto2.ausgabe();

            Console.WriteLine("Überweise 500 von kto 2 auf kto 1");
            kto2.ueberweisenAuf(kto1, 500.0);

            kto1.ausgabe();
            kto2.ausgabe();
            Console.WriteLine("Ziehe Kosten für das Konto ab");

            kto1.kontokostenAbziehen();

            kto1.ausgabe();
            

        }
    }
}
