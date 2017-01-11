namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMobile
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private static decimal callPrice = 0.37m;


        public GSMobile(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.batery = null;
            this.display = null;

        }

        public GSMobile(string model, string manufacturer, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.price = null;
            this.Owner = owner;
            this.batery = null;
            this.display = null;

        }

        public GSMobile(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.batery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Checing.StringChecking(value, "model");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                Checing.StringChecking(value, "manufacturer");
                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            private set
            {
                Checing.StringChecking(value, "owner");
                this.owner = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            private set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new System.ArgumentException("Price must be positive number!");
                }
            }
        }

        
        public override string ToString()
        {
            return string.Format(
                "Model: {0}   Manufacturer: {1}   Price: ${2}   Owner: {3}  ",
                this.model,
                this.manufacturer,
                this.price,
                this.owner) + this.batery.ToString() + this.display.ToString(); ;
        }
        
        public static GSMobile IPhone4S
        {
            get
            {
                return new GSMobile("IPhone4S", "Apple", 250m, "Me", 
                                    new Battery("Non-removable", BatteryType.LiPo, 200, 14), 
                                    new Display(3.5f, 16));
            }
        }

        public void AddCall(DateTime currDateTime, string phone, int duration)
        {
            callHistory.Add(new Call(currDateTime, phone, duration));
        }

        public void RemoveCall(Call current)
        {
            Call itemForRem = callHistory.Find(
                                i => i.Date == current.Date 
                                && i.Time ==current.Time 
                                && i.DialledPhoneNr ==current.DialledPhoneNr 
                                && i.Duration == current.Duration);  
            callHistory.Remove(itemForRem);
        }
        
        public void ClearCallHistory()
        {
            callHistory.Clear();    
        }
        
        public decimal TotalPrice()
        {
            decimal total = 0m;
            int calls = callHistory.Count();
            foreach (Call call in callHistory)
            {
                total += call.Duration;
            }
            total *= callPrice;
            return total;
        }

        public void CallHistoryView()
        {
            foreach(Call call in callHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
