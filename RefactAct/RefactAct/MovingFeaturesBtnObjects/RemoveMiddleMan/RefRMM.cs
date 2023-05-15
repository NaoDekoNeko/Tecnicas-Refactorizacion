using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.RemoveMiddleManRef
{
    class Employee
    {
        public Department WorkDepartment { get; private set; }
    }

    class Department
    {
        public string ChargeCode { get; private set; }
        public Employee Manager { get; private set; }
    }
    class Prueba
    {
        void Test()
        {
            var john = new Employee();
            var johnsManager = john.WorkDepartment.Manager;
        }
    }
}
