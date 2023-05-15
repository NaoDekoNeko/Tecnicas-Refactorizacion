using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.ReplaceTempWQueryRef
{
    class PizzaDelivery
    {
        private int quantity;
        private int itemPrice;

        double CalculateTotal()
        {
            if (BasePrice() > 1000)
            {
                return BasePrice() * 0.95;
            }
            else
            {
                return BasePrice() * 0.98;
            }
        }
        //Query que reemplaza a la variable temporal
        double BasePrice()
        {
            return quantity * itemPrice;
        }
    }
}
