using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LV5;
class MainClass
{
    static void Main()
    {
        ShippingService shippingService = new ShippingService(5);

        Product milk = new Product("Milk", 2.12, 3);
        Product orangeJuice = new Product("Orange Juice", 55, 4);

        Box drinkBox = new Box("Drink Box");

        drinkBox.Add(milk);
        drinkBox.Add(orangeJuice);

        Product potatoes = new Product("Potatoes", 2.55, 3);

        Box magicBox = new Box("Magic Box");

        magicBox.Add(drinkBox);
        magicBox.Add(potatoes);

        System.Console.WriteLine(magicBox.Description());
        OutputSeparationLine();

        System.Console.WriteLine("Total Shipping price: "  + shippingService.CalculateShippingPrice(magicBox));
    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
