using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public class Condiment : Drinkable
    {
        private Drinkable drink = null;
        private Decimal price = 0.00M;
        private Decimal discount = 1.00M;
        private string name = string.Empty;
        private string total = string.Empty;
        private DateTime specialDay = DateTime.Now;

        public Condiment(Drinkable drink)
        {
            this.drink = drink;
        }

        public Condiment(Drinkable drink, string condimentName, Decimal condimentPrice, Decimal discount)
        {
            this.drink = drink;
            this.price = condimentPrice;
            this.discount = discount;
            this.name = condimentName;
        }

        public Condiment(Drinkable drink, string condimentName, Decimal condimentPrice, Decimal discount, DateTime dateTime)
        {
            this.drink = drink;
            this.price = condimentPrice;
            this.discount = discount;
            this.name = condimentName;
            this.specialDay = dateTime;
        }

        public Condiment(Decimal condimentPrice, string condimentName, Decimal discount)
        {
            this.price = condimentPrice;
            this.discount = discount;
            this.name = condimentName;
        }

        public Condiment(Drinkable drink, string condimentName, Decimal condimentPrice)
        {
            this.drink = drink;
            this.price = condimentPrice;
            this.name = condimentName;
        }

        public Condiment( string condimentName,Decimal condimentPrice)
        {
            this.price = condimentPrice;
            this.name = condimentName;
        }

        public string getPrice()
        {
            if (this.discount == 1.00M)
            {
                return this.name + " (" + this.price.ToString("f2") + ")";
            }

            return this.name + " (" + this.price.ToString("f2") + "*" + (this.discount * 100).ToString("f0") + "%" + ")";
        }

        public string getTotal()
        {
            return this.total;
        }

        public Decimal accumulatePrice()
        {
            Decimal condimentSum = 0.00M;

            if (drink == null)
            {
                condimentSum = this.price * this.discount;
            }
            else
            {
                condimentSum = this.drink.accumulatePrice() + this.price * this.discount;
            }

            condimentSum = specialWeek(condimentSum);
            return condimentSum;
        }

        private Decimal specialWeek(Decimal condimentSum)
        {
            if (specialDay.DayOfWeek == DayOfWeek.Friday)
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
