using System;

namespace Homework.Models
{
    public class Battery
    {
        public Battery()
        {
            this.Id = idCounter++;
        }

        
        public Battery(string model):this()
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType batteryType) : this(model)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, BatteryType batteryType, double hoursIdle, double hoursTalk) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        private static int idCounter = 0;
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public BatteryType BatteryType { get; set; }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The battery model cannot be empty or null!");
                }
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("The Idle Hours must be a non negative value!");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Talk Hours must be a non negative value!");
                }
                this.hoursTalk = value;
            }
        }
    }

    // Problem 3 - Placed the enum inside the Battery class because of the tight connection between the two
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCD
    }
}