using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd[] cds = new Cd[5];
            cds[0] = new Cd("blubb");
            cds[1] = new Cd("foo");
            cds[2] = new Cd("bar");
            cds[3] = new Cd("null");
            cds[4] = new Cd("last");
            for (int i = 0; i < cds.Length; i++)
            {
                cds[i].init(i);
                cds[i].Drucken();
            }
        }
    }
}
