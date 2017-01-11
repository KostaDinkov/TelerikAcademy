using System;
using System.Threading;

namespace Homework.Models
{
    class MyDelegateTimer
    {
        public delegate void IntervalElapsedAction();

        private bool isActive;

        public MyDelegateTimer(int interval, IntervalElapsedAction action)
        {
            this.Interval = interval;
            this.TimerActions += action;
        }

        public int Interval { get; set; }

        private IntervalElapsedAction TimerActions { get; set; }

        public void Start()
        {
            this.isActive = true;
            while (this.isActive)
            {
                Thread.Sleep(this.Interval * 1000);
                this.TimerActions();
            }
        }

        public void Stop()
        {
            this.isActive = false;
        }
    }
}