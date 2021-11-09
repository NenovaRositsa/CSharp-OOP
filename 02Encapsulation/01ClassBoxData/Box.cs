using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {

        private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(INVALID_SIDE_MESSAGE, nameof(this.Length)));
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(INVALID_SIDE_MESSAGE, nameof(this.Width)));
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(INVALID_SIDE_MESSAGE, nameof(this.Height)));
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width)
                  +(2 * this.length * this.height)
                  +(2 * this.width * this.height);


        }

        public double LateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);

        }

        public double Volume()
        {
            return this.length * this.width * this.height;

        }
    }
}
