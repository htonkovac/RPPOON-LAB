using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(items.Sum(r => r.CalculatePrice()));
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }
    }
}
