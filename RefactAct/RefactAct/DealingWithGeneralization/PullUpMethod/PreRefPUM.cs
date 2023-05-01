using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.PullUpMethod
{
    public abstract class Unit
    {
        public int _health;
    }
    class Soldier : Unit
    {
        public Soldier()
        {
            _health = 100;
        }
        public int Health { get { return _health; } }
    }
    class Tank: Unit
    {
        public Tank()
        {
            _health = 1200;
        }
        public int Health { get { return _health; } }
    }
}
