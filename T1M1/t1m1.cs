using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1M1
{
    class t1m1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben sie das Guthaben ein:");
            int guthaben = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Geben sie die Laufzeit ein:");
            int laufzeit = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Geben sie den Zinsatz in Prozent ein:");
            double zinssatz = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("Am Ende der Laufzeit haben sie:"+t1m1.ZinsenBerechnen(guthaben,laufzeit,zinssatz));
        }
        static public double ZinsenBerechnen(int guthaben, int laufzeit, double zinssatz)
        {
            double ret = Convert.ToDouble(guthaben);
            zinssatz /= 100;
            for (int i = 0; i < laufzeit; i++)
            {
                ret += ret*zinssatz;
            }
            return ret;
        }
    }
}
