using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraiBarnanenak
{
    class Monitor
    {
        public string Nev { get; set; }
        public string Tipus  { get; set; }
        public int Meret { get; set; }
        public int Raktaron { get; set; }
        public int Ar { get; set; }

        public string Gamer { get; set; }

        public Monitor(string sor,)
        {
            string[] Szortir = sor.Split(";");
            this.Nev = Szortir[0];
            this.Tipus = Convert.ToString(Szortir[1]);
            this.Meret = Convert.ToInt32(Szortir[2]);
            this.Ar = Convert.ToInt32(Szortir[3]);


            this.Raktaron = 15;
            Gamer.set
        }
        public override string ToString()
        {
            return $"{Nev} {Tipus} {Meret} {Raktaron} {Ar} {Gamer}  ";
            
        }
    }
}
