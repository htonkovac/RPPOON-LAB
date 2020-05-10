using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
