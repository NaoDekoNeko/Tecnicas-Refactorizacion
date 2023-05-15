using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.ReplaceTempWQuery
{
    class PizzaDelivery
    {
        private int quantity;
        private int itemPrice;

        double CalculateTotal()
        {
            //variable temporal
            double basePrice = quantity * itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }
    }
    
}
