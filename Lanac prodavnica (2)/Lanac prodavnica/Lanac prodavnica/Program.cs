using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikli a1 = new Artikli(Tip.mlecni, "Imlek", "Mleko kratkotrajno", "tetrapak", new DateTime(2021, 6, 1), "l", "Polica", 50, 100);
            Artikli a2 = new Artikli(Tip.mlecni, "Carnex", "Pilece meso", "folija", new DateTime(2021, 6, 1), "kg", "Frizider", 50, 500);
            Artikli a3 = new Artikli(Tip.mlecni, "Carnex", "Kobasica", "folija", new DateTime(2021, 10, 7), "kg", "Frizider", 50, 100);
            Artikli a4 = new Artikli(Tip.mlecni, "Carnex", "Cajna", "folija", new DateTime(2021, 6, 1), "l", "Frizider", 30, 100);

            var zbirnalista = new List<Artikli>();
            zbirnalista.AddRange(new List<Artikli>{ a1,a2,a3,a4});

            Lager store = new Lager();
            store.addArtikal(a1,3);
            store.addArtikal(a2,2);
            store.addArtikal(a3,3);
            store.addArtikal(a4,2);

            store.PrintLager();
            store.PrintStatistika();
            Prodavnica shop = new Prodavnica(store);
            shop.manage("Andjela");

            store.PrintLager();
            store.PrintStatistika();

        }
    }
}
