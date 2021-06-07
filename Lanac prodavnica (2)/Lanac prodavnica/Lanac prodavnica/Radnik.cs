using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    public enum RadnikUloga { Kasir, Aranzer, Mesar, PekarKuvar, MenadzerProdavnice, 
        MenadzerPoslovneJedinice, PomocnoOsoblje, DirektorPoslovneJedinice, ZaposleniUDirekciji, GeneralniDirektor }
    class Radnik
    {
        static int LastRadnikId = 1;
        private RadnikUloga _uloga;
        public int RadnikId { get; set; }

        public Radnik(RadnikUloga uloga)
        {
            RadnikId=LastRadnikId++;
            _uloga = uloga;
        }
    }
}
