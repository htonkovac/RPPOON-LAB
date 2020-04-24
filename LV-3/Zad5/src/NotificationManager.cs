using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class NotificationManager
    {
        public void Display(ConsoleNotification notification)
        {
            Console.ForegroundColor = notification.Color;
            Console.Write(notification.Author + ": ");
            Console.WriteLine(notification.Title);
            Console.WriteLine(notification.Timestamp.ToString());
            Console.WriteLine(notification.Text);
            Console.WriteLine(notification.Level);
            Console.ResetColor();
        }
    }
}
