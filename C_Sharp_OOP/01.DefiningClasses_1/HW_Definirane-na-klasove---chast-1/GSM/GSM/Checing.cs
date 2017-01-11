namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Checing
    {
        public static void StringChecking(string value, string name)
        {
            if (value == String.Empty)
            {
                throw new System.ArgumentException("The {0} must be set!, name");
            }
        }

    }
}
