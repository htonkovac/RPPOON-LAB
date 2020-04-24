using Zad4;
using System;
class MainClass {
    static void Main() {
        Category category = Category.INFO;
        ConsoleColor color = ConsoleColor.Cyan;
        ConsoleNotification notification = new ConsoleNotification("John Doe", "Notification Title", "Lorem Ipsum Dolorem", DateTime.Now, category, color);
        NotificationManager manager = new NotificationManager();
        manager.Display(notification);
    }

}
