using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.RemoveAssignamentsToParam
{
    class PizzaDelivery
    {
        //Aquí no se especifica que se va a modificar el parametro que se está pasando
        int Discount(int inputVal, int quantity)
        {
            if (quantity > 50)
            {
                inputVal -= 2;
            }
            // ...
            return inputVal;
        }
    }
}
