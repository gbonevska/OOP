using System;
using System.Linq;

namespace ZooWorld
{
    public class Tomcat : Cat
    {
        //methods
        public override string ProduceSound()
        {
            return "marrrrrrrr-mau";
        }

        //consturctor
        public Tomcat(string name, int age)
            : base(name, age, Sexx.Male)
        {
        }
    }
}
