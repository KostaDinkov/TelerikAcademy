using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.Models
{
    public class GSM
    {
        private static int idCounter;

        //Problem 6... not sure if that is what the author wanted ;)
        private static GSM iphone4S = new GSM("Iphone 4s", "Apple")
                                      {
                                          Price = 600,
                                          Battery = new Battery("CoolBatery4s", BatteryType.LiIon),
                                          Display = new Display(29, 16000000)
                                      };

        private string model;
        private decimal price;

        // Problem 2
        public GSM(string model, string manufacturer) : this(model, manufacturer, 0, null, null, null)
        {
            this.Id = idCounter++;
            
        }

        public GSM(string model, string manufacturer, decimal price, Person owner, Battery battery,
                   Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        // Problem 5
        public int Id { get; private set; }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model must have a value");
                }
                this.model = value;
            }
        }

        public string Manufacturer { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be non negarive decimal value");
                }
                this.price = value;
            }
        }

        public Person Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        // Problem 9
        public List<Call> CallHistory { get; set; }

        // Problem 4
        public override string ToString()
        {
            string result = $"GSM - {this.Model}\n" +
                            $"-Manufacturer : {this.Manufacturer}\n" +
                            $"-Price : {this.Price}\n" +
                            $"-Battery :\n" +
                            $"--{this.Battery.BatteryType}\n" +
                            $"--{this.Battery.Model}\n" +
                            $"--hours idle : {this.Battery.HoursIdle}\n" +
                            $"--hours talk : {this.Battery.HoursTalk}\n" +
                            $"-Display :\n" +
                            $"--size : {this.Display.Size}\n" +
                            $"--number of colors : {this.Display.NumberOfColors}\n";

            return result;
        }

        //Problem 10
        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void DeleteCall(DateTime timeStamp, string dialedPhone)
        {
            var call = this.CallHistory.FirstOrDefault(c => (c.Date == timeStamp) && (c.DialedPhone == dialedPhone));
            this.CallHistory.Remove(call);
        }

        public void DeleteCall(int id)
        {
            var call = this.CallHistory.FirstOrDefault(c => c.Id == id);
            CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        // Problem 11

        public decimal CallPrice(decimal pricePerMinute)
        {
            ulong totalCallTime = 0;

            foreach (Call call in CallHistory)
            {
                totalCallTime += call.Duration;
            }

            return Math.Ceiling(totalCallTime / 60m) * pricePerMinute;
        }

        public string GetCallHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.CallHistory.Count} calls found.\n\n");
            foreach (Call call in this.CallHistory)
            {
                sb.Append($"Call Id : {call.Id}\n" +
                                  $"-- Date : {call.Date}\n" +
                                  $"-- Call duration : {call.Duration}\n" +
                                  $"-- Dialed Phone : {call.DialedPhone}\n");
            }

            return sb.ToString();
        }
    }
}