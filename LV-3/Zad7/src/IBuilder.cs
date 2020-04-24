using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4;
using Zad5;
using Zad6;
using Zad7;

namespace Zad5
{
    interface IBuilder
    {
        ConsoleNotification Build();
        IBuilder SetAuthor(String author);
        IBuilder SetTitle(String title);
        IBuilder SetTime(DateTime time);
        IBuilder SetLevel(Category level);
        IBuilder SetColor(ConsoleColor color);
        IBuilder SetText(String text);
    
    }
}
