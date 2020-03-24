using System;

namespace LV1
{
    class TimeStamped: Note
    {   
        private DateTime time;


        public TimeStamped(TimeStamped tp) : base(tp)
        {
            this.time = tp.Time;
        }


        public TimeStamped() : base()
        {
            this.time = DateTime.Now;
        }


        public TimeStamped(String description, String author, int priority) : base(description, author, priority)
        {
            this.time = DateTime.Now;
        }

        public TimeStamped(String description, String author, int priority, DateTime time): base(description, author, priority)
        {
            this.time = time;
        }
        
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }


        public override String ToString() {
            return $"{this.Priority} : {this.GetCompletedStatus()}: {this.Author} : {this.Time} : {this.Description}";
        }
    }
}
