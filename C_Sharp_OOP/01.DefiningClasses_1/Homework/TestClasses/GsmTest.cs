using Homework.Models;

namespace Homework.TestClasses
{
    public static class GsmTest
    {
        public static GSM[] gsms =
        {
            new GSM("Galaxy Note II",
                    "Samsung",
                    299,
                    null,
                    new Battery("K21300", BatteryType.LiIon, 300, 15),
                    new Display(5.5, 16000000)),
            new GSM("Galaxy Note III",
                    "Samsung",
                    499,
                    null,
                    new Battery("Z21300", BatteryType.NiMH, 250, 12),
                    new Display(6, 16000000)),
            new GSM("Iphone 6",
                    "Apple",
                    899,
                    null,
                    new Battery("bul5h1t", BatteryType.NiMH, 250, 12),
                    new Display(6, 16000000)),
        };
    }
}