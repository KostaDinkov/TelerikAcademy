using System;

namespace Shapes
{
    public abstract class Shape
    {
        private double height;
        private double width;

        protected Shape()
        {
        }

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public  double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.width = value;
            }
        }

        public  double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}