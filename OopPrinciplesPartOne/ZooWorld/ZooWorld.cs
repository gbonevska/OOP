using System;
using System.Linq;
using System.Collections.Generic;

namespace ZooWorld
{
    public class ZooWorld
    {
        static void Main()
        {
            Cat[] cats = new Cat[] { new Kitten("Pisana",5),
                                     new Kitten("Missi", 1),
                                     new Tomcat("Muri", 3),
                                     new Tomcat("Tommy",7),
                                   };

            Dog[] dogs = new Dog[] { new Dog("Sharo",3), // will be male because dogs are male by default in class
                                     new Dog("Liso",4, Animal.Sexx.Female),
                                     new Dog("Chernio",1),
                                    };

            Frog[] frogs = new Frog[] { new Frog("frog1",1),
                                        new Frog("frog2",4),
                                        new Frog("frog3",2),
                                      };

            IEnumerable<Animal> sortCats = Animal.sortByAge(cats);
            IEnumerable<Animal> sortDogs = Animal.sortByAge(dogs);
            IEnumerable<Animal> sortFrogs = Animal.sortByAge(frogs);


            Console.WriteLine("Print results:");
            Console.WriteLine("***************************");
            Console.WriteLine("Cats:");
            foreach (var cat in cats)
            {
                Console.WriteLine(cat.Name + " " + cat.Age + " " + cat.Sex + " " + cat.ProduceSound());
            }
            Console.WriteLine();

            Console.WriteLine("Sort cats by age:");
            foreach (var sortCat in sortCats)
            {
                Console.WriteLine(sortCat.Name + " " + sortCat.Age);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dogs:");
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Sex + " " + dog.ProduceSound());
            }
            Console.WriteLine();

            Console.WriteLine("Sort cats by age:");
            foreach (var sortDog in sortDogs)
            {
                Console.WriteLine(sortDog.Name + " " + sortDog.Age);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Frogs:");
            foreach (var frog in frogs)
            {
                Console.WriteLine(frog.Name + " " + frog.Age + " " + frog.Sex + " " + frog.ProduceSound());
            }
            Console.WriteLine();

            Console.WriteLine("Sort frogs by age:");
            foreach (var sortFrog in sortFrogs)
            {
                Console.WriteLine(sortFrog.Name + " " + sortFrog.Age);
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
