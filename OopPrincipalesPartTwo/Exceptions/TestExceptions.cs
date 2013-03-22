using System;

namespace Exceptions
{
    class TestExceptions
    {
        static void Main()
        {
    
            InvalidRangeException<int> someIntExeption = new InvalidRangeException<int>("The have to enter a number in the range from 0 do 100!", 1, 100);
            int[] numbers = new int[] { 3, 101 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("The number " + numbers[i]);
                if (numbers[i] < someIntExeption.Start || numbers[i] > someIntExeption.End)
                {
                    throw someIntExeption;
                }
                else
                {
                    Console.WriteLine("The number {0} is correct!", numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Test dates:");
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            InvalidRangeException<DateTime> dateExpection = 
                new InvalidRangeException<DateTime>("The date isn't in the correct range from 1.1.1980 to 31.12.2013!", startDate, endDate);

            DateTime[] dates = new DateTime[] { DateTime.Now, new DateTime(1979, 3, 1) };
            for (int i = 0; i < dates.Length; i++)
            {

                Console.WriteLine(dates[i]);
                if (dates[i].Year < dateExpection.Start.Year || dates[i].Year > dateExpection.End.Year)
                {
                    throw dateExpection;
                }
                else
                {
                    Console.WriteLine("The date {0} is correct!", dates[i]);
                }
            }

        }
    }
}
