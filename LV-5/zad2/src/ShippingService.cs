using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV5
{
    class ShippingService
    {
        public ShippingService(double pricePerUnitOfWeight) {
            this.pricePerUnitOfWeight = pricePerUnitOfWeight;
        }
        public double pricePerUnitOfWeight;
        public double CalculateShippingPrice( IShipable shipable) {
            return shipable.Weight * this.pricePerUnitOfWeight;
        }

    }
}
