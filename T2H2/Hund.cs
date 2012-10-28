using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2H2
{
    public class Hund : FellSaeugetier
    {
        public Hund(int a, string f, string n, string ft)
            : base(a, f, n, ft)
        {
        }
        public override void GibLaut()
        {
            Console.WriteLine("Ich mache Wau Wau");
        }
    }
}
