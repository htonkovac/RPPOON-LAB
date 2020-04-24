using Zad4;
using Zad5;
using System;
class MainClass {
    static void Main() {
        NotificationManager manager = new NotificationManager();

        IBuilder builder = new NotificationBuilder();
        manager.Display(builder.SetAuthor("John Doe").SetText("Lorem Ipsum").Build());


    }

}
