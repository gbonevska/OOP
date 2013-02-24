using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Battery
    {
        private string model;
        private ushort hoursIdle;
        private ushort hoursTalk;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public ushort HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public ushort HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public Battery(string model, ushort hoursIdle, ushort hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery()
        {
        }
        

    }
}
