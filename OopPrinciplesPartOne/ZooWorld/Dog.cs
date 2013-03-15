using System;
using System.Linq;


namespace ZooWorld
{
    public class Dog : Animal
    {
        // methods
        public override string ProduceSound()
        {
            return "bau-bau";
        }
        //consturctor
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = Sexx.Male;
        }
        public Dog(string name, int age, Sexx sex)
            : this(name, age)
        {
            this.Sex = sex;
        }
    }
}
