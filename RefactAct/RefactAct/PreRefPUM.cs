using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct3
{
    public class PreRefPUM
    {
        public static void Main(string[] args)
        {
            Soldier s = new Soldier();
            Tank t = new Tank();
            s.GetHealth();
            t.GetHealth();
        }       
    }
    public class Unit
    {
    }
    class Soldier : Unit
    {
        public void GetHealth()
        {
            Console.WriteLine("Unit needs health");
        }
    }
    class Tank: Unit
    {
        public void GetHealth()
        {
            Console.WriteLine("Unit needs health");
        }
    }
}
