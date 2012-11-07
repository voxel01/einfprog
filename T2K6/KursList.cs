using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Eine die selbe Klasse wie "Kurs" nur mit Listen umgesetzt, die in dem Fall sinnvoller wären
 */
namespace T2K6
{
    class KursList
    {
        private string kursname;
        private double kurspreis;
        private List<string> teilnehmer;

        public KursList(string kursname, double kurspreis)
        {
            this.kursname = kursname;
            this.kurspreis = kurspreis;
            this.teilnehmer = new List<string>();
        }


        public void AddTeilnehmer(string teilnehmer)
        {
            if (this.teilnehmer.Count >= 10) return; //Nicht mehr als 10 Teilnehmer
            this.teilnehmer.Add(teilnehmer);
        }

        public void DelTeilnehmer(string teilnehmer)
        {
            this.teilnehmer.Remove(teilnehmer);
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
        public List<string> Teilnehmer
        {
            get { return this.teilnehmer; }
            set { this.teilnehmer = value; }

        }

        public void Drucken()
        {
            Console.WriteLine("Kurs: {0}  Kurspreis: {1}",this.kursname, this.kurspreis);
            Console.WriteLine("Kursteilnehmer({0}): ",this.teilnehmer.Count.ToString());
            foreach (string tn in this.teilnehmer)
            {
                Console.WriteLine(" - {0}", tn);
            }
        }
    }
}
