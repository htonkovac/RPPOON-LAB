using System;
using System.Collections.Generic;
using System.Linq;
using Renting;


class MainClass
{
    static void Main()
    {
        RentingConsolePrinter printer = new RentingConsolePrinter();
        List<IRentable> rentables = new List<IRentable>();

        OutputSeparationLine();
        rentables.Add(new Book("The Song of Earth and Fire"));
        rentables.Add(new Video("The Fast and the Furious"));
        printer.DisplayItems(rentables);
        printer.PrintTotalPrice(rentables);
        OutputSeparationLine();

    }

    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }

}
