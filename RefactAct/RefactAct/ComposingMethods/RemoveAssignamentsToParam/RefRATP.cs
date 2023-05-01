using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.RemoveAssignamentsToParamRef
{
    class PizzaDelivery
    {
        int Discount(int inputVal, int quantity)
        {
            //Esta variable temporal ayudará a no cambiar el parametro que se pasa
            var result = inputVal;
            if (quantity > 50)
            {
                result -= 2;
            }
            // ...
            return result;
        }
    }
}
