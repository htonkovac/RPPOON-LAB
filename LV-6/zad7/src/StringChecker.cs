using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    abstract class StringChecker
    {

        private StringChecker next;
        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public void SetNextForLastInChain(StringChecker next) {
            var last = this;
            while (last.next != null) {
                last = last.next;
            }
            last.SetNext(next);
        }
        
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.next != null && result == true)
            {
                return this.next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }

}
