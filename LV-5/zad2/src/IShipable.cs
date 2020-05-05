using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV5
{
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }

}
