using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public class Beverage : IDrink
    {
        private Decimal beveragePrice = 0.00M;
        public string total = "";
        private string beverageName = "";

        public Beverage(Decimal price, string name)
        {
            this.beveragePrice = price;
            this.beverageName = name;
        }

        public Decimal getPrice()
        {
            return beveragePrice;
        }

        public string printF()
        {
            return this.beverageName + " (" + this.beveragePrice.ToString() + ")";
        }

        public string getTotal()
        {
            return this.total;
        }

        public Decimal decorateDrink()
        {
            this.total = " | Total=" + this.beveragePrice.ToString("f2");
            return this.beveragePrice;
        }
    }
}
