using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassPractice
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
        
        //Constructors are below. If you don't specify an alpha value it will default to opaque.
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        //Returns the value of a color
        public int GetRed()
        {
            return red;
        }

        public int GetGreen()
        {
            return green;
        }

        public int GetBlue()
        {
            return blue;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        //sets a new value

        public void SetRed(int red)
        {
            this.red = red;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public int GetGreyscale()
        {
            return ((red + blue + green) / 3);
        }
    }
}
