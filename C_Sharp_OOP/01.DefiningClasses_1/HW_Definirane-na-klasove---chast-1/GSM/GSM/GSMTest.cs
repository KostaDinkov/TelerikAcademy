namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class GSMTest
    {
        public static void GSMobileTest()
        {

            GSMobile[] testArea = {
            new GSMobile("Galaxy S7", "Samsung", 949.99m, "Papa",
                         new Battery("Removable", BatteryType.NiCd, 100, 11),
                         new Display(6.5f, 16)),
            new GSMobile("M18", "Lenovo", 299.99m, "Serena",
                         new Battery("Removable-3", BatteryType.NiMH, 138, 18),
                         new Display(5.5f, 24)),
            new GSMobile("NL800", "LG", 399m, "Zina",
                         new Battery("Removable", BatteryType.LiIon, 250, 21),
                         new Display(6.9f, 20))
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(testArea[i].ToString());
                Console.WriteLine();
            }

        }
    }
}

