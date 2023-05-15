using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.ExtractSubclassRef
{
    class JobItem
    {
        public int TotalPrice { get { return UnitPrice * Quantity; } }
        public virtual int UnitPrice{ get; set; }
        public int Quantity { get; private set; }
        //El item unicamente requiere de su precio unitario y su cantidad
        public JobItem(int unitPrice, int quantity)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
    class LaborItem : JobItem
    {
        public Employee Employee { get; protected set; }
        //Se devuelve el precio unitario si el Item es para un empleado que está trabajando
        public override int UnitPrice 
        {
            get { return Employee.Rate; }
            set { base.UnitPrice = value; }
        }
        //Se agrega al empleado
        public LaborItem(int quantity, Employee employee) : base(0, quantity)
        {
            Employee = employee;
        }
    }
    class Employee
    {
        public int Rate { get; internal set; }
    }
}   
