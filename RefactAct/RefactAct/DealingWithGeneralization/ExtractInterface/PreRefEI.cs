using RefactAct.ExtractInterfaceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ExtractInterface
{
    class Employee
    {
        public int Rate { get; set; }
        public bool HasSpecialSkill { get; private set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    class TimeSheet
    {
        public Employee Employee { get; private set; }
        //Aquí se está pasando todo el objeto empleado, aunque solo se usan dos de sus propiedades
        public double GetCharge(int days)
        {
            double result = Employee.Rate * days;
            if (Employee.HasSpecialSkill)
            {
                result *= 1.05;
            }
            return result;
        }
    }
}
