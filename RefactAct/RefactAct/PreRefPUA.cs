using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct4
{
    internal class PreRefPUA
    {
        public static void Main(string[] args)
        {
            Soldier s = new Soldier();
            Tank t = new Tank();
            Console.WriteLine("Soldier health is: " + s.health);
            Console.WriteLine("Tank health is " + t.health);
        }
    }
    class Unit
    {

    }
    class Soldier : Unit
    {
        public int health = 100;
    }
    class Tank : Unit
    {
        public int health = 1200;
    }
}
