using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.MoveMethod
{
    class Account
    {
        public double DaysOverdrawn { get; private set; }

        public double GetOverdraftChange()
        {
            //Si la cuenta es premium o no
            if (Type.IsPremium)
            {
                var result = 10.0;
                if(DaysOverdrawn > 7)
                {
                    result += (DaysOverdrawn - 7) * 0.85;
                }
                return result;
            }
            return DaysOverdrawn * 1.20;
        }
        public AccountType Type { get; private set; }
    }
    class AccountType
    {
        public bool IsPremium { get; set; }
    }
}
