using System;
using System.Collections.Generic;
using System.Linq;
using LV7;


class MainClass
{
    static void Main()
    {
        Cart cart = new Cart();
        cart.AddItem(new Book("The book of ice and fire", 123.00));
        cart.AddItem(new Book("Harry Potter", 46.00));
        cart.AddItem(new DVD("Cinderella", DVDType.SOFTWARE, 34.00));
        cart.AddItem(new DVD("How I met your mother", DVDType.MOVIE , 99.00));
        cart.AddItem(new VHS("Charlie Chaplin", 11.00));
        cart.AddItem(new VHS("Old Movie", 67.00));
        
        double buyPrice = cart.Accept(new BuyVisitor());
        double rentPrice = cart.Accept(new RentVisitor());

        Console.WriteLine("Buy price: "+ buyPrice);
        Console.WriteLine("Rent price: "+ rentPrice);



    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
