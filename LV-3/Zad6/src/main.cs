using Zad4;
using Zad5;
using Zad6;
using System;
class MainClass {
    static void Main() {
        NotificationManager manager = new NotificationManager();
        Director director = new Director();
        manager.Display(director.BuildNotification_ALERT("Ivo"));
        manager.Display(director.BuildNotification_ERROR("Marko"));
        manager.Display(director.BuildNotification_INFO("Zdravko"));

    }

}
