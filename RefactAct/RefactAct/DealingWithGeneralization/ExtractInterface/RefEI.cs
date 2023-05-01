using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ExtractInterfaceRef
{
    class Employee:IBillable
    {
        public int Rate { get; set; }
        public bool HasSpecialSkill { get; private set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    //Esta interfaz solo pasará los datos pertinentes del empleado
    interface IBillable
    {
        int Rate { get; }
        bool HasSpecialSkill { get; }
    }
    class TimeSheet
    {
        //se cambió el tipo de objeto empleado a la interfaz,
        //además se cambió el nombre de Employee a Resources
        //para que refleje mejor las propiedades que pasa
        public IBillable Resources { get; private set; }
        public double GetCharge(int days)
        {
            double result = Resources.Rate * days;
            if(Resources.HasSpecialSkill)
            {
                result *= 1.05;
            }
            return result;
        }
    }
}
