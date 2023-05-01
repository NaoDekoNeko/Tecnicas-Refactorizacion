using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.PullUpField
{
    public abstract class Unit
    {
    }
    class Soldier : Unit
    {
        public int Health { get; set; }
    }
    class Tank : Unit
    {
        public int Health { get; set; }
    }
}
