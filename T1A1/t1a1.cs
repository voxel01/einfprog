using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1A1
{
    class t1a1
    {

        static void Main(string[] args)
        {
            int max = 1500;
            ushort[] values = new ushort[max];
            
            for (ushort i = 2; i <= max; i++)
            {
                values[i-1] = i;
            }
            
            foreach(ushort key in values)
            {
                if (key == 0) continue;
                if (key == 1) continue;
                Console.WriteLine(key);
                for(ushort multi = 2;multi*key <= max;multi++)
                {
                    values.SetValue(null, (multi * key)-1);
                }
            }

            /*
            foreach (ushort key in values)
            {
                if (key == 0) continue;
            }*/
        }

    }
}
