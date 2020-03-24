
using System;
using LV1;

class MainClass {
    static void Main() {
        Note n1 = new Note();
        Note n2 = new Note("New note", "Mark", 1);
        Note n3 = new Note(n2);

        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        System.Console.WriteLine(n3);

    }
}