namespace GSM
{
    using System;

    internal class Call
    {
        private DateTime date;
        private string time;
        private string dialledPhoneNr;
        private int duration;

        public string DialledPhoneNr
        {
            get { return this.dialledPhoneNr; }
            private set
            {
                Checing.StringChecking(value, "dialled phone number");
                this.dialledPhoneNr = value;
            }
        }

        public int Duration {
            get { return this.duration; }
            private set
            {
                if (duration < 0)
                {
                    throw new System.ArgumentException("Calls' Duration can't be negative!");
                }
                this.duration = value;
            }
         }

        public DateTime Date {
            get { return this.date; }
            private set { this.date = value; } }

        public string Time {
            get { return this.time; }
            private set { this.time = value; } }

        public Call(DateTime currDateTime, string phone, int duration)
        {
            this.Date = currDateTime.Date;
            this.Time = currDateTime.ToString("HH:mm");
            this.DialledPhoneNr = phone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Date: {0} {1} h  Phone: {2}  Duration: {3}", 
                            this.Date, this.Time, this.DialledPhoneNr , this.Duration);
        }
    }
}