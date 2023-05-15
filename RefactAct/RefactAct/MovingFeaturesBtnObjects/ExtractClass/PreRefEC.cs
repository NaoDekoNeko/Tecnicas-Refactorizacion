using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.ExtractClass
{
    class Person
    {
        public string Name { get; private set; }

        public string OfficeAreaCode { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string OfficeFullNumber
        {
            get { return "(" + OfficeAreaCode + ")" + OfficePhoneNumber; }
        }
    }
}
