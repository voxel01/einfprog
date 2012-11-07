using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Klasse stellt einen Kurs dar.
 * 
 * Da bisher keine Listen durchgenommen wurden, mit Arrays umgesetzt
 */
namespace T2K6
{
    class Kurs
    {
        private string kursname;
        private double kurspreis;
        private string[] teilnehmer;

        public Kurs(string kursname, double kurspreis)
        {
            this.kursname = kursname;
            this.kurspreis = kurspreis;
            this.teilnehmer = new string[0];
        }


        public void AddTeilnehmer(string teilnehmer)
        {
            if (this.teilnehmer.Length >= 10) return; //Nicht mehr als 10 Teilnehmer
            string[] n = new string[this.teilnehmer.Length + 1];
            this.teilnehmer.CopyTo(n, 0);
            n[this.teilnehmer.Length] = teilnehmer;
            this.teilnehmer = n;
        }

        public void DelTeilnehmer(int index)
        {
            if (index < 0 || index >= this.teilnehmer.Length) return; //Array out of range
            string[] n = new string[this.teilnehmer.Length - 1];
            for (int i=0; i < this.teilnehmer.Length; i++)
            {
                if (i == index) continue;
                n[(i < index ? i : i - 1)] = this.teilnehmer[i];
            }
            this.teilnehmer = n;
        }

        
        public string Kursname
        {
            get { return kursname; }
            set { kursname = value; }

        }

        public double Kurspreis
        {
             get { return kurspreis; }
             set { kurspreis = value; }

        }
        public string[] Teilnehmer
        {
            get { return this.teilnehmer; }
            set { this.teilnehmer = value; }

        }

        public void Drucken()
        {
            Console.WriteLine("Kurs: {0}  Kurspreis: {1}",this.kursname, this.kurspreis);
            Console.WriteLine("Kursteilnehmer({0}): ",this.teilnehmer.GetLength(0).ToString());
            foreach (string tn in this.teilnehmer)
            {
                Console.WriteLine(" - {0}", tn);
            }
        }
    }
}
