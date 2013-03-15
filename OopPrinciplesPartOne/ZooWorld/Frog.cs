using System;
using System.Linq;


namespace ZooWorld
{
    public class Frog : Animal
    {
        // methods
        public override string ProduceSound()
        {
            return "krqk-krqk";
        }

        //consturctor
        public Frog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = Sexx.Female;
        }
        public Frog(string name, int age, Sexx sex)
            : this(name, age)
        {
            this.Sex = sex;
        }
    }
}
