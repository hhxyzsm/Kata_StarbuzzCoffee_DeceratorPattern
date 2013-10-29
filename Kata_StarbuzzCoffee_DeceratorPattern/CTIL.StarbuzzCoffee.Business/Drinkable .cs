using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public interface Drinkable
    {
        Decimal accumulatePrice();
        string getPrice();
        string getTotal();
    }
}
