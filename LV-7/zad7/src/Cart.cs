using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    class Cart
    {
        public List<IItem> items = new List<IItem>();
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public double Accept(IVisitor visitor)
        {
            return this.items.Sum(item =>
            {
                var val = item.Accept(visitor);
                if (double.IsNaN(val)) {
                    return 0;
                } 
                return val;
            });
        }

    }
}
