using System;
using System.Collections.Generic;
using LV6;


class MainClass {
    static void Main() {
    CareTaker careTaker = new CareTaker();
    ToDoItem item = new ToDoItem("BIG TITLE", "Lorem Impsum Dolorem", DateTime.Now);
    System.Console.WriteLine(item);
    OutputLineSeparator();
    careTaker.AddState(item.StoreState());

    item.Rename("BIGGER TITLE");
    System.Console.WriteLine(item);
    OutputLineSeparator();

    item.RestoreState(careTaker.GetPreviousState());
    System.Console.WriteLine(item);
    OutputLineSeparator();

    item.ChangeTask ("This is a very important task :)");
    careTaker.AddState(item.StoreState());
    System.Console.WriteLine(item);
    OutputLineSeparator();


    item.ChangeTimeDue(DateTime.Today);
    careTaker.AddState(item.StoreState());
    System.Console.WriteLine(item);
    OutputLineSeparator();

    item.RestoreState(careTaker.GetInitialState());
    System.Console.WriteLine(item);
    OutputLineSeparator();

    }
    static void OutputLineSeparator() {
        System.Console.WriteLine("----------------------");
    }
}
