using System;

namespace Homework.Models
{
    public class Display
    {
        private static int idCounter;
        private uint numberOfColors;
        private double size;

        public Display()
        {
        }

        public Display(string manufacturer, double size, uint numberOfColors)
        {
            this.Manufacturer = manufacturer;
            this.Size = size;
            this.NumberOfColors = numberOfColors;
            this.Id = idCounter++;
        }

        public Display(double size, uint numberOfColors) : this(null, size, numberOfColors)
        {
        }

        public Display(double size) : this(size, 0)
        {
        }

        public int Id { get; set; }
        public string Manufacturer { get; set; }

        public double Size  
        {
            get { return this.size; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("Display size must be non negative value!");
                }
                this.size = value;
            }
        }

        public uint NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <1)
                {
                    throw new ArgumentOutOfRangeException("The number of colors for the display must be more than 0!");
                }
                this.numberOfColors = value;
            }
        }
    }
}