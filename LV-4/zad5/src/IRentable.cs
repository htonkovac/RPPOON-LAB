using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }

}
