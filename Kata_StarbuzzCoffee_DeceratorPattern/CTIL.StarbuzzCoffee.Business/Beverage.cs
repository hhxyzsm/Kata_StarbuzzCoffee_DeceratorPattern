using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public class Beverage : Drinkable
    {
        private Decimal beveragePrice = 0.00M;
        private string total = string.Empty;
        private string beverageName = string.Empty;

        public Beverage( string name,Decimal price)
        {
            this.beveragePrice = price;
            this.beverageName = name;
        }

        public string getPrice()
        {
            return this.beverageName + " (" + this.beveragePrice.ToString() + ")";
        }

        public string getTotal()
        {
            return this.total;
        }

        public Decimal accumulatePrice()
        {
            this.total = " | Total=" + this.beveragePrice.ToString("f2");
            return this.beveragePrice;
        }
    }
}
