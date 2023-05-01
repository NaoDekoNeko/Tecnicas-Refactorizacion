using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.CollapseHierarchyRef
{
    //La clase deja de ser abstracta
    class Employee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        //Agregado el único campo que pertenecía a la subclase
        public string MobileNumber { get; set; }
    }
}
