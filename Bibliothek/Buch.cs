using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliothek
{
    class Buch
    {
        private uint maxBüchermenge = 0;
        public Buch(uint anzahl)
        {
            this.maxBüchermenge = anzahl;
        }
        public bool Entleihen()
        {
            if(this.maxBüchermenge == 0) return false;
            this.maxBüchermenge--;
            return true;
        }
        public void Rueckgabe()
        {
            this.maxBüchermenge++;
        }
        public uint Anzahl()
        {
            return this.maxBüchermenge;
        }
        public void Drucken()
        {
            Console.WriteLine("Vom Buch sind noch {0} Stk lagernd",this.maxBüchermenge);
        }
    }
}
