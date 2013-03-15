using System;
using System.Collections.Generic;
using System.Linq;


namespace Humans
{
    class HumansCommunity
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Dragan", "Tzankov", 6.00f));
            students.Add(new Student("Petkan", "Zafirov", 3.68f));
            students.Add(new Student("Ivan", "Ivanov", 4.25f));
            students.Add(new Student("Penka", "Shopova", 5.40f));
            students.Add(new Student("Liliana", "Dimitrova", 5.58f));
            students.Add(new Student("Lubka", "Kuncheva", 6.0f));
            students.Add(new Student("Pencho", "Kratunkov", 4.56f));
            students.Add(new Student("Atanas", "Tashev", 4.80f));
            students.Add(new Student("Georgi", "Dimitrov", 2.50f));
            students.Add(new Student("Kosta", "Tzankov", 3.70f));

            Console.WriteLine("Print students:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine(student.PrintStudent());
            }
            Console.WriteLine();

            IEnumerable<Student> sortStudents = new List<Student>();
            // flagSort = 1 -> ascending, 2 = descending
            sortStudents = Student.Sorting(students, 1);

            Console.WriteLine("Print ascending sort students by grade :");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var sortStudent in sortStudents)
            {
                Console.WriteLine(sortStudent.PrintStudent());
            }
            Console.WriteLine();
            
            Console.WriteLine("*************************************************");
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Draganov", 300m));
            workers.Add(new Worker("Petar", "Petrov", 3000m, 8));
            workers.Add(new Worker("Angel", "Angelov"));
            workers.Add(new Worker("Georgi", "Georgiev", 1500m, 7));
            workers.Add(new Worker("Atanas", "Spasov", 870m, 5));
            workers.Add(new Worker("Ivan", "Ivanov", 700m));
            workers.Add(new Worker("Dragan", "Draganov", 400m));
            workers.Add(new Worker("Lubka", "Draganova", 6500m));
            workers.Add(new Worker("Kalinka", "Vuchkova", 870m));
            workers.Add(new Worker("Anastasia", "Popova", 1300m));

            Console.WriteLine("Print list of workers:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.PrintWorker());
            }
            Console.WriteLine();

            IEnumerable<Worker> sortWorkers = new List<Worker>();
            // flagSort = 1 -> ascending, 2 = descending
            sortWorkers = Worker.Sorting(workers, 2);

            Console.WriteLine("Print descending sort workers by MoneyPerHour:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var sortWorker in sortWorkers)
            {
                Console.WriteLine(sortWorker.PrintWorker());
            }
            Console.WriteLine();

            Console.WriteLine("*************************************************");
            Console.WriteLine();

            List<Human> humans = new List<Human>();
            foreach (var student in students)
            {
                humans.Add(student);
            }
            foreach (var worker in workers)
            {
                humans.Add(worker);
            }

            Console.WriteLine("Print merge workers and students in humans group:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var human in humans)
            {
                Console.WriteLine(human.GetName());
            }
            Console.WriteLine();


            IEnumerable<Human> sortHumans = new List<Human>();
            // flagSort = 1 -> ascending, 2 = descending
            sortHumans = Human.Sorting(humans, 1);

            Console.WriteLine("Sorting humans by fist name and last name ascending");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            foreach (var sortHuman in sortHumans)
            {
                Console.WriteLine(sortHuman.GetName());
            }
        }
    }
}
