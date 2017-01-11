namespace GSM
{
    class Display
    {
        private float size;
        private int numberOfColors;

        public Display(float size, int colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }

        public float Size
        {
            get { return this.size; }
            private set
            {
                if (value > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new System.ArgumentException("Display size must be positive number!");
                }
            }
        }

        public int NumberOfColors {
            get { return this.numberOfColors; }
            private set {
                if (value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new System.ArgumentException("Nuber of colors must be positive number!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Display size: {0} inches  Display colors: {1} M",
                this.size,
                this.numberOfColors);
        }
    }
}