using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ExtractSubclass
{
    class JobItem
    {
        private int _unitPrice;
        public Employee Employee
        {
            get; private set;
        }
        private bool IsLabor { get; set; }
        public int TotalPrice   {get { return UnitPrice * Quantity; }}
        //Precio unitario del producto según si el empleado está trabajando
        public int UnitPrice
        {
            get { return IsLabor ? Employee.Rate : _unitPrice; }
            set { _unitPrice = value; }
        }
        public int Quantity { get; private set; }
        //El item depende obligatoriamente de un ID de empleado aunque este no esté trabajando
        public JobItem(int unitPrice, int quantity, bool isLabor, Employee employee)
        {
            UnitPrice = unitPrice;
            IsLabor = isLabor;
            Quantity = quantity;
            Employee = employee;
        }
    }
    class Employee
    {
        public int Rate { get; internal set; }
    }
}
