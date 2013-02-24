using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Display
    {
        private int height;
        private int width;
        private long numberOfColors;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public long NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public Display(int height, int width, long numberOfColors)
        {
            this.height = height;
            this.width = width;
            this.numberOfColors = numberOfColors;
        }
        public Display()
        { 
        }

        public int Size()
        {
            return this.height * this.width;
        }
    }
}
