using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad1;
using Zad4;
using Zad5;
using Zad6;

namespace Zad7
{
    public enum Category { ERROR, ALERT, INFO }
 
   /**
     * U ovom slucaju nema razlike izmedju dubokog i plitkog kopiranja 
     * ConsoleColor je u pozadini zapravo int
     * Author, Title, Text su Stringovi
     * DateTime je struct
     */
    class ConsoleNotification : Prototype
    {
        public String Author{ get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }

        public ConsoleNotification(String author, String title, String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        public Prototype Clone() {
           return (Prototype)this.MemberwiseClone();
        }

    }
}
