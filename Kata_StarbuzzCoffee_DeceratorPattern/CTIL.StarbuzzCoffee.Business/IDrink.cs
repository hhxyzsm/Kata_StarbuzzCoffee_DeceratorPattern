using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTIL.StarbuzzCoffee.Business
{
    public interface IDrink
    {
        Decimal decorateDrink();
        string printF();
        string getTotal();
        Decimal getPrice();
    }
}
