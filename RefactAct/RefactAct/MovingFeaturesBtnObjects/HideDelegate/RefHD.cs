using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.HideDelegateRef
{
    class Employee
    {
        public Department WorkDepartment { get; private set; }
        public string ChargeCode { get { return WorkDepartment.ChargeCode; } }
        public Employee Manager { get { return WorkDepartment.Manager; } }
    }

    public class Department
    {
        public string ChargeCode { get; set; }
        internal Employee Manager { get; set; }
    }
    class Prueba
    {
        void Test()
        {
            var john = new Employee();
            var johnsManager = john.Manager;
        }
    }
}
