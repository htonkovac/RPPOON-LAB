using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    public enum DVDType { SOFTWARE, MOVIE }
    class DVD : IItem
    {
        public string Description { get; private set; }
        public double Price { get; private set; }
        public DVDType Type { get; private set; }
        public DVD(string description, DVDType type, double price)
        {
            this.Description = description;
            this.Type = type;
            this.Price = price;
        }
        public override string ToString()
        {
            return "DVD: " + this.Type + " " +
            this.Description + Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor) { return visitor.Visit(this); }
    }


}
