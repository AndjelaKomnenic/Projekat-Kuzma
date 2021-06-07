using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Prodavnica
    {
        private Lager store;

        public Prodavnica(Lager store)
        {
            this.store = store;

        }

        public void manage(String customer)
        {
            Korpa basket = new Korpa();
            Console.WriteLine(Environment.NewLine + "Prodavnica " + customer);
            Console.WriteLine("-------------------");
            Console.WriteLine("Dostupni artikli na legeru: ");
            foreach (String product in store.products())
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Koji proizvod da dodamo na racun? ");
                String product = Console.ReadLine();
                if (String.IsNullOrEmpty(product))
                {
                    break;
                }

                if (store.stanje(product) > 0)
                {
                    store.uzmi(product);
                    basket.add(product, store.price(product));
                    Console.WriteLine(" OK");
                }
                else
                {
                    Console.WriteLine($"Nema vise na lageru {product}.");
                }


            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Racun:{Environment.NewLine}");
            basket.print();
            Console.WriteLine($"Datum:{basket.datetimeret()}| Broj kase: {basket.regnoret()}| Broj blagajnika:{basket.cashnoret()}| Ukupna cena:{basket.price()}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
