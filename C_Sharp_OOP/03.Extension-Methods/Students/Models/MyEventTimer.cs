using System;
using System.Threading;

namespace Homework.Models
{
    public class MyEventTimer
    {
        public delegate void IntervalElapsedEventHandler(object sender, EventArgs e);

        private bool isActive;
        public int Interval { get; set; }

        public void Start()
        {
            this.isActive = true;
            while (this.isActive)
            {
                Thread.Sleep(this.Interval * 1000);
                this.OnIntervalElapsed();
            }
        }

        public void Stop()
        {
            this.isActive = false;
        }

        public event IntervalElapsedEventHandler IntervalElapsed;

        public virtual void OnIntervalElapsed()
        {
            this.IntervalElapsed?.Invoke(this, EventArgs.Empty);
        }
    }

    public class TimerMessageService
    {
        public void OnIntervalElapsed(object sender, EventArgs e)
        {
            Console.WriteLine("Message Service: Interval elapsed!");
        }
    }
}