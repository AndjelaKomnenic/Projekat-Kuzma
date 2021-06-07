using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Racun
    {
        private String product;
        private double amount;
        private double unitPrice;
        private DateTime IssueDateTime { get; set; }
        private int RegisterNo { get; set; }
        private int CashierNo { get; set; }

        public Racun(String product, double amount, double unitPrice, DateTime issueDateTime, int registerNo, int cashierNo)
        {

            this.product = product;
            this.amount = amount;
            this.unitPrice = unitPrice;
            this.IssueDateTime = issueDateTime;
            this.RegisterNo = registerNo;
            this.CashierNo = cashierNo;

        }

        public DateTime datum()
        {

            return IssueDateTime;

        }
        public int regno()
        {

            return RegisterNo;

        }
        public int cashno()
        {

            return CashierNo;

        }
        public double price()
        {

            return amount * unitPrice;

        }


        public void increaseAmount()
        {
            this.amount = this.amount + 1;
        }

        public override String ToString()
        {

            String s = "";

            s = s + this.product + ": " + this.amount + "*" + this.unitPrice + "=" + this.amount * this.unitPrice;

            return s;

        }
    }
}
