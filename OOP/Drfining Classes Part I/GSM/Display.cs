using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Display
    {
        private float size;
        private string numberOfColors = null;

        public Display(int size)
            : this(size, null)
        {
        }

        public Display(float size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        

        public float Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value >= 0 || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                
                this.numberOfColors = value;
                
                
            }
        }

        
        public override string ToString()
        {
            StringBuilder endText = new StringBuilder();
            endText.AppendLine("Display:");
            endText.AppendLine(string.Format("Size: {0}",size.ToString()));
            endText.AppendLine(string.Format("Number of Colors: {0}",this.numberOfColors));
            return endText.ToString();
        }
    }
}
