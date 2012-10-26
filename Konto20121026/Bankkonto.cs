using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto20121026
{
    class Bankkonto : Konto
    {
        public Bankkonto(string inh)
            : base(inh)
        {

        }
        public Bankkonto(string inh, double sald)
            : base(inh, sald)
        {

        }
        public Bankkonto (string inh, double sald, double zins) : base(inh, sald, zins) {

        }
        public void kontokostenAbziehen()
        {
            this.saldo -= 10.5;
        }
    }
}
