
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    class RentVisitor : IVisitor
    {
        private const double rentMultiplier = 0.1;

        public double Visit(DVD DVDItem)
        {
            if(DVDItem.Type == DVDType.SOFTWARE) return double.NaN;
            return DVDItem.Price * rentMultiplier;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * rentMultiplier;
        }
        public double Visit(Book book)
        {
            return book.Price * rentMultiplier;
        }
    }
}
