using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2H2
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Saeugetier a = new Katze(3,"schwarz","Katze 1","langhaar");

            Katze b = new Katze(5, "braun", "Katze 2", "kurzhaar");

            a.Drucken();
            b.Drucken();
        }
    }
}
