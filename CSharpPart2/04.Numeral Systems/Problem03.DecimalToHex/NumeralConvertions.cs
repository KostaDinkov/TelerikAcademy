using System;

namespace Problem03.DecimalToHex
{
    
    
    public static class NumeralConvertions
    {
        const int base10 = 10;
        const int asciiDiff = 48;
        public static char[] cHexa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
        public static int[] iHexaNumeric = new int[] { 10, 11, 12, 13, 14, 15 };
        public static int[] iHexaIndices = new int[] { 0, 1, 2, 3, 4, 5 };

        public static string DecimalToBase(int iDec, int numbase)
        {

            string strBin = "";
            int[] result = new int[32];
            int maxBit = 32;
            for (; iDec > 0; iDec /= numbase)
            {
                int rem = iDec % numbase;
                result[--maxBit] = rem;
            }
            for (int i = 0; i < result.Length; i++)
                if ((int)result.GetValue(i) >= base10)
                    strBin += cHexa[(int)result.GetValue(i) % base10];
                else
                    strBin += result.GetValue(i);
            strBin = strBin.TrimStart(new char[] { '0' });
            return strBin;
        }

        public static int BaseToDecimal(string sBase, int numbase)
        {
            int dec = 0;
            int b;
            int iProduct = 1;
            string sHexa = "";
            if (numbase > base10)
                for (int i = 0; i < cHexa.Length; i++)
                    sHexa += cHexa.GetValue(i).ToString();
            for (int i = sBase.Length - 1; i >= 0; i--, iProduct *= numbase)
            {
                string sValue = sBase[i].ToString();
                if (sValue.IndexOfAny(cHexa) >= 0)
                    b = iHexaNumeric[sHexa.IndexOf(sBase[i])];
                else
                    b = (int)sBase[i] - asciiDiff;
                dec += (b * iProduct);
            }
            return dec;
        }
    }
    
}
