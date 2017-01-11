namespace GSM
{
    class Battery
    {
        private string model;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType type; 


        public Battery(string model, BatteryType type)
        {
            this.Model = model;
            this.type = type;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public Battery(string model, BatteryType type, float hourh1, float hours2)
        {
            this.Model = model;
            this.type = type;
            this.HoursIdle = hourh1;
            this.HoursTalk = hours2;
        }

        public string Model {
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

        public float? HoursIdle {
            get { return this.hoursIdle; }
            private set
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new System.ArgumentException("Hours idle must be nonnegative number!");
                }
            }
            }

        public float? HoursTalk
        {
            get { return this.hoursTalk; }
            private set
            {
                if (value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new System.ArgumentException("Hours talk must be nonnegative number!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Battery model: {0}  Battery type: {1}  Hourse idle: {2} h  Hours talk: {3} h ",
                this.model,
                this.type,
                this.hoursIdle,
                this.hoursTalk);
        }
    }
}