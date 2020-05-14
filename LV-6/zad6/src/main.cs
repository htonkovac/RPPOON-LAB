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

            stringLenghtChecker.SetNext(upperCaseChecker);
            upperCaseChecker.SetNext(lowerCaseChecker);
            lowerCaseChecker.SetNext(digitChecker);


        System.Console.WriteLine(stringLenghtChecker.Check("1"));
        System.Console.WriteLine(stringLenghtChecker.Check(""));
        System.Console.WriteLine(stringLenghtChecker.Check("1dD"));
        System.Console.WriteLine(stringLenghtChecker.Check("1d3"));
        System.Console.WriteLine(stringLenghtChecker.Check("DDDDDDDD"));





    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
