using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto20121026
{
    public class Konto
    {
        //Saldo des Kontos
        private double saldo = 0;
        //Zinssatz der bei dem Konto angewandt wird
        private double zinssatz = 0;
        //Inhaber des Kontos
        private string inhaber;

        /**
         * überladene Konstruktoren für die Klasse
         */
        public Konto(string inh)
        {
            this.inhaber = inh;
        }
        public Konto(string inh, Double saldo):this(inh)
        {
            this.saldo = saldo;
        }
        public Konto(string inh, Double saldo, Double zinssatz):this(inh,saldo)
        {
            this.zinssatz = zinssatz;
        }
        //Gibt das aktuelle Saldo reour
        public double getSaldo()
        {
            return this.saldo;
        }
        //Hebt etwas vom Konto ab
        public bool abheben(double wert)
        {
            this.saldo -= wert;
            return true;
        }
        //Zahlt etwas auf das Konto ein
        public bool einzahlen(double wert)
        {
            this.saldo += wert;
            return true;
        }
        //Getter und Setter für den Inhaber des Kontos
        public string Inhaber
        {
            get
            {
                return this.inhaber;
            }
            set
            {
                this.inhaber = value;
            }
        }
        //Getter und Setter für den Zinssatz
        public double Zinssatz
        {
            get
            {
                return this.zinssatz;
            }
            set
            {
                this.zinssatz = value;
            }
        }
        //Überweist einen Betrag von einem Konto auf ein anderes
        public void ueberweisenAuf(Konto kto, double wert)
        {
            this.abheben(wert);
            kto.einzahlen(wert);
        }
        //Ausgabe der Kontodaten
        public void ausgabe()
        {
            Console.WriteLine("Konto von "+this.inhaber+" mit Saldo "+ this.saldo.ToString());
        }
        //Berechnet die Zinsen auf dem Konto
        public void zinsenBerechnen()
        {
            this.saldo += this.saldo / 100 * this.zinssatz;
        }
    }
}
