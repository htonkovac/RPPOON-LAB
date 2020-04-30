using System;
using System.Collections.Generic;
using System.Linq;
using Renting;


class MainClass {
    static void Main() {
        RentingConsolePrinter printer = new RentingConsolePrinter();
        List<IRentable> rentables = new List<IRentable>();

        OutputSeparationLine();
        rentables.Add(new Book("The Song of Earth and Fire"));
        rentables.Add(new Video("The Fast and the Furious"));
        printer.DisplayItems(rentables);
        printer.PrintTotalPrice(rentables);


        OutputSeparationLine();
        rentables.Add(new HotItem(new Book("Lord of the Rings")));
        rentables.Add(new HotItem(new Video("Bee Movie 2")));
        printer.DisplayItems(rentables);
        printer.PrintTotalPrice(rentables);
        OutputSeparationLine();

        List<IRentable> discountedRentables = new List<IRentable>();
        discountedRentables = rentables.Select( x => (IRentable)(new DiscountedItem(x,50))).ToList();

        printer.DisplayItems(discountedRentables);
        printer.PrintTotalPrice(discountedRentables);
        OutputSeparationLine();

    }


    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
