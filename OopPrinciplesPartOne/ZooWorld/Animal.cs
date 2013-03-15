using System;
using System.Linq;
using System.Collections.Generic;


namespace ZooWorld
{


    public abstract class Animal : ISound
    {
        public enum Sexx
        {
            Female,
            Male,
        };

        // fields
        private int age;
        private string name;
        private Sexx sex;

        // properties
        public int Age
        {
            get { return age; }
            set 
            {
                if (value != null)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    name = "animal without name";
                }
            }
        }

        public Sexx Sex
        {
            get { return sex; }
            set 
            {
                if (value != null)
                {
                    sex = value;
                }
                else
                {
                    sex = Sexx.Female;
                }
            }
        }

        // methods
        public virtual string ProduceSound()
        {
            return "I'm animal.";
        }

        public static IEnumerable<Animal> sortByAge(Animal[] animals)
        {
            IEnumerable<Animal> sortAnimals =
                        from animal in animals
                     orderby animal.age
                      select animal;

            return sortAnimals;
        }

    }
}
