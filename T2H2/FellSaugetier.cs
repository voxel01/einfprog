using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2H2
{
    public abstract class FellSaeugetier : Saeugetier
    {
        private string felltyp;
        public FellSaeugetier(int a, string f, string n, string ft)
            : base(a, f, n)
        {
            this.felltyp = ft;
        }
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Mein Felltyp ist {0}",this.felltyp);
        }
    }
}
