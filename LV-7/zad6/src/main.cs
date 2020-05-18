using System;
using System.Collections.Generic;
using System.Linq;
using LV7;


class MainClass
{
    static void Main()
    {
        List<IItem> items = new List<IItem>();
        items.Add(new Book("The book of ice and fire", 123.00));
        items.Add(new Book("Harry Potter", 46.00));
        items.Add(new DVD("Cinderella", DVDType.SOFTWARE, 34.00));
        items.Add(new DVD("How I met your mother", DVDType.MOVIE , 99.00));
        items.Add(new VHS("Charlie Chaplin", 11.00));
        items.Add(new VHS("Old Movie", 67.00));

        items.Select(item => item.Accept(new RentVisitor())).ToList()
            .ForEach(item => Console.WriteLine(item));


    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
