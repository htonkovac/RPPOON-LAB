using Zad4;
using Zad5;
using Zad6;
using Zad7;
using System;
class MainClass {
    static void Main() {
        NotificationManager manager = new NotificationManager();
        Director director = new Director();
        ConsoleNotification notif =  director.BuildNotification_ALERT("Ivo");
        manager.Display(notif);
        ConsoleNotification notifClone = (ConsoleNotification) notif.Clone();
        manager.Display(notifClone);     

    }

}
