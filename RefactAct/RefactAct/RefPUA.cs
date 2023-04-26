using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct2
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Unit s = new Soldier();
            Unit t = new Tank();
            Console.WriteLine("Soldier health is: " + s.health);
            Console.WriteLine("Tank health is " + t.health);
        }
    }
    public abstract class Unit
    {
        public int health;
    }
    class Soldier : Unit
    {
        public Soldier()
        {
            this.health = 100;
        }
    }
    class Tank : Unit
    {
        public Tank()
        {
            this.health = 1200;
        }
    }
}
