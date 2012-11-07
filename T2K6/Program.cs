using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2K6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs tanzkurs = new Kurs("Tanzkurs", 130);

            tanzkurs.AddTeilnehmer("Teilnehmer A");
            tanzkurs.AddTeilnehmer("Teilnehmer B");
            tanzkurs.AddTeilnehmer("Teilnehmer C");
            tanzkurs.AddTeilnehmer("Teilnehmer D");
            tanzkurs.AddTeilnehmer("Teilnehmer E");

            tanzkurs.Drucken();

            tanzkurs.DelTeilnehmer(3);

            tanzkurs.Drucken();


            KursList mathekurs = new KursList("Mathekurs", 130);

            mathekurs.AddTeilnehmer("Teilnehmer A");
            mathekurs.AddTeilnehmer("Teilnehmer B");
            mathekurs.AddTeilnehmer("Teilnehmer C");
            mathekurs.AddTeilnehmer("Teilnehmer D");
            mathekurs.AddTeilnehmer("Teilnehmer E");

            mathekurs.Drucken();

            mathekurs.DelTeilnehmer("Teilnehmer C");

            mathekurs.Drucken();
        }
    }
}
