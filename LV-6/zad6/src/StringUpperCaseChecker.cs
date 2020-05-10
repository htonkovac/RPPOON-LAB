using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class StringUpperCaseChecker : StringChecker
    {
        protected bool PerformCheck(string stringToCheck) {
            return stringToCheck.Any(char.IsUpper);
        }
    }

}
