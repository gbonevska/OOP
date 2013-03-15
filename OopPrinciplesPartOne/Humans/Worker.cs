using System;
using System.Collections.Generic;
using System.Linq;

namespace Humans
{
    public class Worker : Human
    {
        //fields
        private decimal weekSalary;
        private int workHoursPerDay;

        //properties
        public decimal WeekSalary
        {
          get { return weekSalary; }
          set { weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        //methods

        //returns money earned by hour by the worker -- I accept that one work week has 5 work days
        public decimal MoneyPerHour()
        {  
            decimal moneyHourWorker = 0m;
            if (this.WorkHoursPerDay > 0)
            {
                moneyHourWorker = Math.Round(WeekSalary / (5 * WorkHoursPerDay),2);
            }
            return moneyHourWorker;
        }

        // methods
        public override string GetName()
        {
            return "Worker: " + this.FirstName + " "+ this.LastName;
        }

        public string PrintWorker()
        {
            return GetName() + " WeekSalary = " + WeekSalary + " WorkHoursPerDay = " + WorkHoursPerDay + " MoneyPerHour = " + MoneyPerHour();
        }

        public static IEnumerable<Worker> Sorting(List<Worker> workers, int flagSort)
        {
            IEnumerable<Worker> sortWorkers = new List<Worker>();
            if (flagSort == 1)
            {
                sortWorkers =
                       from worker in workers
                    orderby worker.MoneyPerHour() ascending
                     select worker;
            }
            if (flagSort == 2)
            {
                sortWorkers =
                      from worker in workers
                    orderby worker.MoneyPerHour() descending
                     select worker;
            }
            return sortWorkers;
        }

        //constructors
        public Worker(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = 0m;
            this.workHoursPerDay = 0;
        }
        public Worker(string firstName, string lastName, decimal weekSalary)
            : this(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = 8; // as default hours per day
        }
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : this(firstName, lastName, weekSalary)
        {
            this.workHoursPerDay = workHoursPerDay; 
        }

    }
}
