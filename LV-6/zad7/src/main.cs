using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
        PasswordValidator validator = new PasswordValidator();
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
