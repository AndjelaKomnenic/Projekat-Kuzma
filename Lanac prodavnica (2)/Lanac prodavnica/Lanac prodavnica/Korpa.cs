using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Korpa
    {
        Dictionary<String, Racun> basket = new Dictionary<String, Racun>()
        {
        };

        public Korpa()
        {

        }

        public void add(String product, Double price)
        {
            Random rnd = new Random();
            Racun p = new Racun(product, 1, price, DateTime.Today, rnd.Next(1, 200), rnd.Next(300, 1000));

            if (basket.ContainsKey(product))
            {

                basket[product].increaseAmount();

            }
            else
            {


                basket[product] = p;
            }

        }

        public Double price()
        {

            double price = 0;


            foreach (Racun p in basket.Values)
            {
                price = price + p.price();
            }

            return price;

        }

        public void print()
        {

            String s = "";

            foreach (Racun p in basket.Values)
            {
                s = s + p + "\n";
            }
            Console.WriteLine(s);

        }

        public DateTime datetimeret()
        {
            DateTime dt = DateTime.Today;
            foreach (Racun p in basket.Values)
            {
                dt = p.datum();
            }
            return dt;
        }
        public int regnoret()
        {
            int rr = 0;
            foreach (Racun p in basket.Values)
            {
                rr = p.regno();
            }
            return rr;
        }
        public int cashnoret()
        {
            int cr = 0;
            foreach (Racun p in basket.Values)
            {
                cr = p.cashno();
            }
            return cr;
        }
    }
}
