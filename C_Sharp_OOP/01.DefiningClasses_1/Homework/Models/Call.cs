using System;

namespace Homework.Models
{
    // Problem 8
    public class Call
    {
        private static int idCounter = 0;
        public Call()
        {
            this.Id = idCounter++;
        }

        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public ulong Duration{ get; set; }
        public string DialedPhone { get; set; }
    }
}