using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
        CareTaker careTaker = new CareTaker();
        BankAccount account = new BankAccount("John Doe", "George Washington Boulevar 123", 0);
        careTaker.AddState(account.CreateMemento());
        System.Console.WriteLine(account);

        account.UpdateBalance(12.00m);
        account.ChangeOwnerAddress("Green Trees Street 12");
        System.Console.WriteLine(account);
        careTaker.AddState(account.CreateMemento());

        account.UpdateBalance(2000.00m);
        System.Console.WriteLine(account);
        careTaker.AddState(account.CreateMemento());

        account.UpdateBalance(200000000000000000.00m);
        account.RestoreFromMemento(careTaker.GetPreviousState());
        System.Console.WriteLine(account);
        account.RestoreFromMemento(careTaker.GetInitialState());
        System.Console.WriteLine(account);

    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
