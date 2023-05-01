using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.CollapseHierarchy
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
    class SalesMan : Employee
    {
        //El número de movil perfectamente podría estar dentro de la clase empleado
        public string MobileNumber { get; set; }
    }
}
