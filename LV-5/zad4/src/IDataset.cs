using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    interface IDataset

    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
