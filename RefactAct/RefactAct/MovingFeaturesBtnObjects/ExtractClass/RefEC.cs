using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.ExtractClassRef
{
    class Person
    {
        public string Name { get; private set; }
        public PhoneNumber OfficeNumber { get; set; }

        public string OfficeAreaCode
        {
            get { return OfficeNumber.OfficeAreaCode; }
            set { OfficeNumber.OfficeAreaCode = value; }
        }
        public string OfficePhoneNumber
        {
            get { return OfficeNumber.OfficePhoneNumber; }
            set { OfficeNumber.OfficePhoneNumber = value; }
        }
        public string OfficeFullNumber
        {
            get { return OfficeNumber.OfficeFullNumber; }
        }
        Person()
        {
            OfficeNumber = new PhoneNumber();
        }
    }
    class PhoneNumber
    {
        public string OfficeAreaCode { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string OfficeFullNumber
        {
            get { return "(" + OfficeAreaCode + ")" + OfficePhoneNumber; }
        }
    }
}
