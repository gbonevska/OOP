using System;
using System.Linq;


namespace ZooWorld
{
    public class Cat : Animal
    {
        // methods
        public override string ProduceSound()
        {
            return "mau-mau";
        }

        public Cat(string name, int age, Sexx sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
