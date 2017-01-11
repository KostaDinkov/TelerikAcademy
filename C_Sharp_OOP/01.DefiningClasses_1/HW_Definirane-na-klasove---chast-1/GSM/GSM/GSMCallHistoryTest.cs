namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSMobile phone = new GSMobile("Galaxy S7", "Samsung", 949.99m, "Papa",
                         new Battery("Removable", BatteryType.NiCd, 100, 11),
                         new Display(6.5f, 16));

            Console.WriteLine(phone.ToString());

            phone.AddCall(DateTime.Now, "+35900472475", 583);
            phone.AddCall(DateTime.Now, "+9584635244757", 115);
            phone.AddCall(DateTime.Now, "+9583652758", 18);

            phone.CallHistoryView();

            Console.WriteLine("The total prise is ${0:f2} ", phone.TotalPrice());

            Call one = new Call(DateTime.Now, "+35900472475", 583);

            phone.RemoveCall(one);
            phone.CallHistoryView();

            Console.WriteLine("The total prise after removing of one element is ${0:f2} ", phone.TotalPrice());

            phone.ClearCallHistory();
            phone.CallHistoryView();

            Console.WriteLine("The total prise after clearing list is ${0:f2} ", phone.TotalPrice());
        }
    }
}
