
using System;
using LV1;

class MainClass {
    static void Main() {
        TimeStamped n1 = new TimeStamped();
        TimeStamped n2 = new TimeStamped("New TimeStamped", "Mark", 1);
        TimeStamped n3 = new TimeStamped(n2);

        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        System.Console.WriteLine(n3);

    }
}