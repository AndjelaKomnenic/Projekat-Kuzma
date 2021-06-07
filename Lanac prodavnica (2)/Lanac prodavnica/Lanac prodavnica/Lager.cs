using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Lager
    {
        private Dictionary<String, Double> prices = new Dictionary<String, Double>();
        private Dictionary<String, Double> stocks = new Dictionary<String, Double>();

        public void addArtikal(Artikli art, Double stock)
        {

            prices.Add(art.Naziv, art.Cena);
            stocks.Add(art.Naziv, stock);
        }
        public double price(String product)
        {
            if (prices.ContainsKey(product))
            {
                return prices[product];
            }
            else
            {
                return -99;
            }
        }

        public double stanje(String artikal)
        {
            if (stocks.ContainsKey(artikal))
            {
                return stocks[artikal];
            }
            else
            {
                return 0;
            }
        }
        public bool uzmi(String artikal)
        {
            if (stocks.ContainsKey(artikal))
            {
                if ((stocks[artikal] - 1) >= 0)
                {
                    stocks[artikal] = stocks[artikal] - 1;
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }
        public HashSet<String> products()
        {

            return prices.Keys.ToHashSet();

        }

        public void PrintLager()
        {
            foreach (var lager in stocks)
            {
                Console.WriteLine($"Kod: {lager.Key} | Dostupna kolicina:{lager.Value}");
            }

        }

        public int BrojArtikala()
        {
            return this.stocks.Count();
        }

        public double BrojProizvoda()
        {
            return this.stocks.Select(x => x.Value).Sum();
        }

        public double VrednostLagera()
        {
            double vrednost = 0;
            foreach (string key in stocks.Keys)
            {
                if (prices.ContainsKey(key))
                { vrednost += stocks[key] * prices[key]; }
            }
            return vrednost;

        }

        public void PrintStatistika()
        {
            Console.WriteLine($"{Environment.NewLine}Broj artikala:{this.BrojArtikala()} | Broj proizvoda:{this.BrojProizvoda()} | Vrednost lagera:{this.VrednostLagera()}");
        }

    }
}

