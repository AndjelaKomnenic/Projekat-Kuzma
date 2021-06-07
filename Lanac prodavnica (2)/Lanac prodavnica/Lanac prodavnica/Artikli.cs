using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    public enum Tip { trajni, mlecni, sveze_meso, mesne_preradjevine, peciva_kuvana_hrana, voce_povrce, zaledjeni_program }
    class Artikli
    {
        static int ArtikalId = 1;

        public int Id { get; set; }
        public string Proizvodjac { get; set; }
        public string Naziv { get; set; }
        private double _cena;
        private Tip _tip;
        public int MyProperty { get; set; }
        public string Ambalaza { get; set; }
        public DateTime RokTrajanja { get; set; }
        public string JedinicaProdaje { get; set; }
        public string UsloviCuvanja { get; set; }
        public double ProcenatPopusta { get; set; }
        public double Cena
        {
            get => _cena;
            set
            {
                if ((RokTrajanja - DateTime.Today).TotalDays <= 10)
                {
                    double temp = value;
                    _cena = (1 - (ProcenatPopusta / 100)) * value;
                    Console.WriteLine($"Promena cene({Naziv}) sa {temp} na {_cena}");

                }
                else
                {
                    _cena = value;
                }
            }
        }

        public Artikli(Tip tip, string proizvodjac, string naziv, string ambalaza, DateTime rokTrajanja, string jedinicaProdaje, string usloviCuvanja, double procenatPopusta, double cena)
        {
            Id = ArtikalId++;
            _tip = tip;
            Proizvodjac = proizvodjac;
            Naziv = naziv;
            Ambalaza = ambalaza;
            RokTrajanja = rokTrajanja;
            JedinicaProdaje = jedinicaProdaje;
            UsloviCuvanja = usloviCuvanja;
            ProcenatPopusta = procenatPopusta;
            Cena = cena;
        }

    }

}
