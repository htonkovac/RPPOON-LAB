using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class Memento
    {

        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Memento(string title, string text, DateTime timeDue, DateTime creationTime)
        {
            this.Title = title;
            this.Text = text;
            this.TimeDue = timeDue;
            this.CreationTime = creationTime;
        }
    }
}
