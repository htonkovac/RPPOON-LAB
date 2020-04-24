using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4;

namespace Zad5
{

    class NotificationBuilder: IBuilder
    {
        String author = String.Empty;
        String title = String.Empty;
        DateTime time = DateTime.Now;
        Category level = Category.ERROR;
        ConsoleColor color = ConsoleColor.DarkGreen;
        String text = String.Empty; 

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }
        public IBuilder SetAuthor(String author) { this.author = author; return this; }
        public IBuilder SetTitle(String title) { this.title = title; return this; }
        public IBuilder SetTime(DateTime time) { this.time = time; return this; }
        public IBuilder SetLevel(Category level) { this.level = level; return this; }
        public IBuilder SetColor(ConsoleColor color) { this.color = color; return this; }
        public IBuilder SetText(String text) { this.text = text; return this; }

    }
}
