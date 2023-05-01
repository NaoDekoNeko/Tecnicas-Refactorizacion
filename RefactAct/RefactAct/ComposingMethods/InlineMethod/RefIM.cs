using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.InlineMethodRef
{
    class PizzaDelivery
    {
        private int numberOfLateDeliveries;

        // ...
        public int Rating
        {
            get {  return numberOfLateDeliveries > 5 ? 2 : 1 ; }
        }
    }
}
