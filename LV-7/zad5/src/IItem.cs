using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    interface IItem

    {
        double Accept(IVisitor visitor);
    }

}
