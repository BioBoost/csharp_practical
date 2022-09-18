using System;
using System.Collections.Generic;
using System.Text;

namespace ICanHearColors
{
    public class Color
    {
        public int GetRed()
        {
            return red;
        }

        public void SetRed(int red)
        {
            if (red < 0)
            {
                red = 0;
            }
            else if (red > 255)
            {
                red = 255;
            }

            this.red = red;
        }

        public int GetBlue()
        {
            return blue;
        }

        public void SetBlue(int blue)
        {
            if (blue < 0)
            {
                blue = 0;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

            this.blue = blue;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetGreen(int green)
        {
            if (green < 0)
            {
                green = 0;
            }
            else if (green > 255)
            {
                green = 255;
            }

            this.green = green;
        }

        public override string ToString()
        {
            return $"Red: {GetRed()} | Green: {GetGreen()} | Blue: {GetBlue()}";
        }

        private int red = 0;
        private int green = 0;
        private int blue = 0;
    }
}
