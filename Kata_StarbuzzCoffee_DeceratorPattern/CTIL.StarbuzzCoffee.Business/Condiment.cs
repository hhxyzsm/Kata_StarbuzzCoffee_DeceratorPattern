using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public class Condiment : IDrink
    {
        private IDrink drink = null;
        private Decimal condimentPrice = 0.00M;
        private Decimal condimentDiscount = 1.00M;
        private string condimentName;
        public string total = "";
        private DateTime specialDay = DateTime.Now;

        public Condiment(IDrink drink)
        {
            this.drink = drink;
        }

        public Condiment(IDrink drink, Decimal condimentPrice, Decimal discount, string condimentName)
        {
            this.drink = drink;
            this.condimentPrice = condimentPrice;
            this.condimentDiscount = discount;
            this.condimentName = condimentName;
        }

        public Condiment(IDrink drink, Decimal condimentPrice, Decimal discount, string condimentName, DateTime dateTime)
        {
            this.drink = drink;
            this.condimentPrice = condimentPrice;
            this.condimentDiscount = discount;
            this.condimentName = condimentName;
            this.specialDay = dateTime;
        }

        public Condiment(Decimal condimentPrice, Decimal discount, string condimentName)
        {
            this.condimentPrice = condimentPrice;
            this.condimentDiscount = discount;
            this.condimentName = condimentName;
        }

        public Condiment(IDrink drink, Decimal condimentPrice, string condimentName)
        {
            this.drink = drink;
            this.condimentPrice = condimentPrice;
            this.condimentName = condimentName;
        }

        public Condiment(Decimal condimentPrice, string condimentName)
        {
            this.condimentPrice = condimentPrice;
            this.condimentName = condimentName;
        }

        public Decimal getPrice()
        {
            return this.condimentPrice;
        }

        public string printF()
        {
            if (this.condimentDiscount == 1.00M)
            {
                return this.condimentName + " (" + this.condimentPrice.ToString("f2") + ")";
            }

            return this.condimentName + " (" + this.condimentPrice.ToString("f2") + "*" + (this.condimentDiscount * 100).ToString("f0") + "%" + ")";
        }

        public string getTotal()
        {
            return this.total;
        }

        public Decimal decorateDrink()
        {
            Decimal condimentSum = 0.00M;

            if (drink == null)
            {
                condimentSum = this.condimentPrice * this.condimentDiscount;
            }
            else
            {
                condimentSum = this.drink.decorateDrink() + this.condimentPrice * this.condimentDiscount;
            }

            if (specialDay.DayOfWeek.ToString() == "Friday")
            {
                this.total = " | Total=" + condimentSum.ToString("f2") + "*90%=" + (condimentSum * 0.9M).ToString("f2");
                condimentSum = condimentSum * 0.9M;
            }
            else
            {
                this.total = " | Total=" + condimentSum.ToString("f2");
            }
            return condimentSum;
        }
    }
}
