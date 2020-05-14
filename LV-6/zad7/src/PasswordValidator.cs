using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class PasswordValidator
    {
        StringChecker stringChecker;

        public PasswordValidator(StringChecker stringChecker)
        {
            this.stringChecker = stringChecker;
        }

        public void AddStringChecker(StringChecker newStringChecker) {
            this.stringChecker.SetNextForLastInChain(newStringChecker);
        }
        public bool ValidatePassword(String password)
        {
            return stringChecker.Check(password);
        }
    }
}
