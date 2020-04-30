using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountPercent = 20;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public DiscountedItem(IRentable rentable, double discountPercent) : base(rentable) { this.DiscountPercent = discountPercent;}
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * (100 - this.DiscountPercent)/100;
        }
        public override String Description
        {
            get
            {
                return "Flash SALE!: " + base.Description + " Now at " + this.DiscountPercent + "% off";
            }
        }
    }
}
