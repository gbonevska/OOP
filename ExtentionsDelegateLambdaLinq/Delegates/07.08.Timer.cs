using System;
using System.Linq;
using System.Timers;


namespace Delegates
{
    // Declaration of a delegate
    public delegate void TimerDelegate(int t);

    public class Timer1
    {
        /* 07. Using delegates write a class Timer that has can execute certain method at each t seconds. */
        /* 08. * Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.
         These two task are implements together
         * */
        public static void Timer(int t)
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(PrintText);
            // Set the Interval to 5 seconds.
            aTimer.Interval = t*1000;
            aTimer.Enabled = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q');
        }

        public static void PrintText(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }

        public static void RunTimer()
        {
            
        }

        static void Main()
        {
            TimerDelegate d = new TimerDelegate(Timer);

            Console.WriteLine("Test of task 07/08 delegate on class Timer with event handler:");
            d(2);

        }
    }
}
