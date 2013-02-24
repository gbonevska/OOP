using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class GSM
    {
        private string model;
        private string manifacturer;
        private float price;
        private string owner;
        private Display display = new Display();
        private Battery battery = new Battery();

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manifacturer
        {
            get { return manifacturer; }
            set { manifacturer = value; }
        }
       
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }


    }
}
