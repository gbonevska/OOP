using System;
using System.Linq;


namespace ZooWorld
{
    public class Kitten : Cat
    {
        //methods
        public override string ProduceSound()
        {
            return "mauuuuuuu-mau";
        }

        //consturctor
        public Kitten(string name, int age)
            : base(name, age, Sexx.Female)
        {
        }

    }
}
