using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4;
using Zad5;
using Zad6;
using Zad7;

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
