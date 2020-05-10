using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {

        Product product1 =  new Product("First Product", 20.90);
        Product product2 = new Product("Second Product", 33.22);

        Box box = new Box();

        box.AddProduct(product1);
        box.AddProduct(product2);

        IAbstractIterator boxIterator = box.GetIterator();
        
        while (!boxIterator.IsDone) {
            Console.WriteLine(boxIterator.Current);
            boxIterator.Next();
        }

    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
