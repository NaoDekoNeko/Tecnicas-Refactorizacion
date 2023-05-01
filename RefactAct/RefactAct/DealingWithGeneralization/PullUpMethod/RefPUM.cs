using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct.PullUpMethodRef
{
    public abstract class Unit
    {
        private int _health;

        public int Health { get { return _health; } set { _health = value; } }
    }
    class Soldier : Unit
    {
        public Soldier()
        {
            Health = 100;
        }
    }
    class Tank : Unit
    {
        public Tank()
        {
            Health = 1200;
        }
    }
}