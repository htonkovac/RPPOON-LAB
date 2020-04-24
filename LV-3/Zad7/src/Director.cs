using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4;
using Zad5;
using Zad7;

namespace Zad6
{
    class Director
    {
        IBuilder builder = new NotificationBuilder();

        public ConsoleNotification BuildNotification_ERROR(String author)
        {
            return builder.SetAuthor(author).SetTitle("ERROR").SetText("An ERROR has occured").SetColor(ConsoleColor.DarkMagenta)
                .SetLevel(Category.ERROR).Build();
        }

        public ConsoleNotification BuildNotification_ALERT(String author)
        {
            return builder.SetAuthor(author).SetTitle("ALERT").SetText("ALERT ALERT ALERT").SetColor(ConsoleColor.DarkRed)
                .SetLevel(Category.ALERT).Build();
        }

        public ConsoleNotification BuildNotification_INFO(String author)
        {
            return builder.SetAuthor(author).SetTitle("INFO").SetText("INFO INFO INFO").SetColor(ConsoleColor.DarkYellow)
               .SetLevel(Category.INFO).Build();
        }

    }
}
