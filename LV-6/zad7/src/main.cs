using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
            var upperCaseChecker = new StringUpperCaseChecker();
            var lowerCaseChecker = new StringLowerCaseChecker();
            var digitChecker = new StringDigitChecker();
            var stringLenghtChecker = new StringLenghtChecker();
            
        PasswordValidator validator = new PasswordValidator(stringLenghtChecker);
        validator.AddStringChecker(lowerCaseChecker);
        validator.AddStringChecker(digitChecker);
        validator.AddStringChecker(upperCaseChecker);

        
        System.Console.WriteLine(validator.ValidatePassword("1"));
        System.Console.WriteLine(validator.ValidatePassword(""));
        System.Console.WriteLine(validator.ValidatePassword("1dD"));
        System.Console.WriteLine(validator.ValidatePassword("1d3"));
        System.Console.WriteLine(validator.ValidatePassword("DDDDDDDD"));

    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
