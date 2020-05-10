using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
