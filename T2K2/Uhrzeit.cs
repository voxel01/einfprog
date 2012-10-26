using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2K2
{
    class Uhrzeit
    {
        private long sec = 0;
        public Uhrzeit(int hh, int mm, int ss)
        {
            this.SetUhrzeit(hh, mm, ss);
        }
        public void SetUhrzeit(int hh, int mm, int ss)
        {
            this.sec = hh * 3600 + mm * 60 + ss;
        }
        public void Add(Uhrzeit t2)
        {
            this.sec += t2.sec;
        }
        public void Sub(Uhrzeit t2)
        {
            this.sec -= t2.sec;
        }
        public void Diff(Uhrzeit t2, out int hh, out int mm, out int ss)
        {
            long diff = Math.Abs(this.sec - t2.sec);
            this.getInts(diff,out hh,out mm,out ss);
        }
        public void Drucken()
        {
        }
        private void getInts(long sec, out int hh, out int mm, out int ss)
        {
            hh = Convert.ToInt32(sec / 3600);
            sec = sec % 3600;
            mm = Convert.ToInt32(sec / 60);
            ss = Convert.ToInt32(sec % 60);
        }
    }
}
