using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.MovingFeaturesBtnObjects.MoveMethodRef
{
    class Account
    {
        public double DaysOverdrawn { get; private set; }
    }
    class AccountType
    {
        public bool IsPremium { get; set; }
        //El método ahora pertenece a esta clase
        public double GetOverdraftChange(Account account)
        {
            if (IsPremium)
            {
                var result = 10.0;
                if (account.DaysOverdrawn > 7)
                {
                    result += (account.DaysOverdrawn - 7) * 0.85;
                }
                return result;
            }
            return account.DaysOverdrawn * 1.20;
        }
    }

}
