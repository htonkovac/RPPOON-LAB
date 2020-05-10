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

        public PasswordValidator()
        {
            var upperCaseChecker = new StringUpperCaseChecker();
            var lowerCaseChecker = new StringLowerCaseChecker();
            var digitChecker = new StringDigitChecker();
            var stringLenghtChecker = new StringLenghtChecker();

            stringLenghtChecker.SetNext(upperCaseChecker);
            upperCaseChecker.SetNext(lowerCaseChecker);
            lowerCaseChecker.SetNext(digitChecker);

            this.stringChecker = stringLenghtChecker;
        }

        public bool ValidatePassword(String password)
        {
            return stringChecker.Check(password);
        }
    }
}
