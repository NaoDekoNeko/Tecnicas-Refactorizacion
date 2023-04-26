using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactAct
{
    public class RefPUM
    {
        public static void Main(string[] args)
        {
            Unit s = new Soldier();
            Unit t = new Tank();
            s.GetHealth();
            t.GetHealth();
        }   
    }
    public abstract class Unit
    {
        public void GetHealth()
        {
            Console.WriteLine("Unit needs health");
        }
    }
    class Soldier : Unit
    {
    }
    class Tank : Unit
    {
    }
}