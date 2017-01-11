namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            GSMTest.GSMobileTest();
            Console.WriteLine(GSMobile.IPhone4S.ToString());
            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
