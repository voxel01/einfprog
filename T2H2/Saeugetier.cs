using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2H2
{
    public abstract class Saeugetier
    {
        private int alter;

        private string fellfarbe;
        private string name;

        public Saeugetier(int a, string f, string n)
        {
            this.alter = a;
            this.fellfarbe = f;
            this.name = n;
        }

        public virtual void Drucken()
        {
            Console.WriteLine("Mein Name ist {0} und ich bin {1} Jahre alt. Meine Fellfarbe ist: {2}",this.name,this.alter.ToString(),this.fellfarbe);
        }

        public abstract void GibLaut();
    }
}
