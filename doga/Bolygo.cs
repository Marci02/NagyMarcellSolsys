using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzama { get; set; }
        public double Aranya { get; set; }

        public Bolygo(string v)
        {
            string[] adatok = v.Split(';');
            Nev = adatok[0];
            HoldSzama = int.Parse(adatok[1]);
            Aranya = double.Parse(adatok[2].Replace('.' , ','));
        }
    }
}
