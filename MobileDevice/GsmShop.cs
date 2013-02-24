using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GsmShop
    {
        static void Main()
        {
            GSM phoneOne = new GSM();
            phoneOne.Manifacturer = "Sony";
            phoneOne.Model = "Xperia";
            phoneOne.Owner = "Geri";
            phoneOne.Price = 860.50f;
            phoneOne.Battery.Model = "LiteOn";
            phoneOne.Battery.HoursIdle = 1000;
            phoneOne.Battery.HoursTalk = 20;
            phoneOne.Display.Height = 15;
            phoneOne.Display.Width = 6;
            phoneOne.Display.NumberOfColors = 6000000;

            GSM phoneTwo = new GSM();
            phoneTwo.Manifacturer = "Sony";
            phoneTwo.Model = "Xperia GO";
            phoneTwo.Owner = "Viki";
            phoneTwo.Price = 540f;
            phoneTwo.Battery.Model = "LiteOn 5";
            phoneTwo.Battery.HoursIdle = 800;
            phoneTwo.Battery.HoursTalk = 15;
            phoneTwo.Display.Height = 10;
            phoneTwo.Display.Width = 5;
            phoneTwo.Display.NumberOfColors = 6000000;
            

            Console.WriteLine("The phone model{0} is bought by {1} for {2} leva.",
                                phoneOne.Model, phoneOne.Owner, phoneOne.Price);
            Console.WriteLine("The phone has next battery characteristics: batery model: {0},  hours Idle: {1} and hours Talk {2}.",
                                phoneOne.Battery.Model, phoneOne.Battery.HoursIdle, phoneOne.Battery.HoursTalk);
            Console.WriteLine("The phone display has next characteristics: display size is {0} and number of display colors is {1}.",
                                phoneOne.Display.Size(), phoneOne.Display.NumberOfColors);


            Console.WriteLine("The phone model{0} is bought by {1} for {2} leva.",
                                phoneTwo.Model, phoneTwo.Owner, phoneTwo.Price);
            Console.WriteLine("The phone has next battery characteristics: batery model: {0},  hours Idle: {1} and hours Talk {2}.",
                                phoneTwo.Battery.Model, phoneTwo.Battery.HoursIdle, phoneTwo.Battery.HoursTalk);
            Console.WriteLine("The phone display has next characteristics: display size is {0} and number of display colors is {1}.",
                                phoneTwo.Display.Size(), phoneTwo.Display.NumberOfColors);
        }
    }
}
