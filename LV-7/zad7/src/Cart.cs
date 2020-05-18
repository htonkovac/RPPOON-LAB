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
                if (item is Book)
                {
                    return visitor.Visit((Book)item);
                }

                if (item is DVD)
                {
                    double result = visitor.Visit((DVD)item);
                    if (!Double.IsNaN(result))
                        return result;
                }

                if (item is VHS)
                {
                    return visitor.Visit((VHS)item);
                }
                return 0;
            });
        }

    }
}
