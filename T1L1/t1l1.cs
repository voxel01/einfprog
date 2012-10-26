using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1L1
{
    class t1l1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Operand ('*','/'):");
            string operand = Console.ReadLine();

            int erg = 0;
            switch (operand)
            {
                case "/":
                    while (zahl1 >= zahl2)
                    {
                        erg++;
                        zahl1 -= zahl2;
                    }
                    Console.WriteLine("Ergebnis: " + erg + " und " + zahl1 + "Rest");
                    break;
                case "*":  //Multiplizieren als Defauloperand
                default:
                    for (int i = 0; i < zahl2; i++)
                    {
                        erg += zahl1;
                    }
                    Console.WriteLine("Ergebnis: "+erg);
                        break;
            }

        }
    }
}
