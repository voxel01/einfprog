using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD
{
    class Cd
    {
        public class Track
        {
            private string name = "";
            private uint dauer = 0; //In Sekunden
            public Track(string name, uint dauer)
            {
                this.name = name;
                this.dauer = dauer;
            }
            public string Name{
                get{ return this.name;}
            }
            public uint Dauer{
                get{ return this.dauer;}
            }
        }

        protected string titel;
        protected Track[] tracks;
        public Cd(string titel)
        {
            this.titel = titel;
            this.tracks = new Track[5];
        }
        public void init(int seed)
        {
            Random rand = new Random(seed);
            this.tracks[0] = new Track("a", Convert.ToUInt32(rand.Next(10, 50)));
            this.tracks[1] = new Track("b", Convert.ToUInt32(rand.Next(10, 50)));
            this.tracks[2] = new Track("c", Convert.ToUInt32(rand.Next(10, 50)));
            this.tracks[3] = new Track("d", Convert.ToUInt32(rand.Next(10, 50)));
            this.tracks[4] = new Track("e", Convert.ToUInt32(rand.Next(10, 50)));
        }

        public void Drucken()
        {
            Console.WriteLine("CD {0}, Dauer {1} Sekunden",this.titel, this.Dauer);
            for (int i = 0; i < this.tracks.Length; i++)
            {
                Console.WriteLine("Track {0} heißt {1} und ist {2} Sekunden lang",i,this.tracks[i].Name,this.tracks[i].Dauer);
            }
        }

        public uint Dauer
        {
            get
            {
                uint summ = 0;
                for (int i = 0; i < this.tracks.Length; i++)
                {
                    summ += this.tracks[0].Dauer;
                }
                return summ;
            }
        }
    }
}
