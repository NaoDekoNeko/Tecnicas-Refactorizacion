using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ComposingMethods.InlineMethod
{
    class PizzaDelivery
    {
        private int numberOfLateDeliveries;

        // ...
        public int Rating
        {
            get { return MoreThanFiveLateDeliveries() ? 2 : 1; }
        }
        bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}
