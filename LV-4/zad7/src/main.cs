using System;
using System.Collections.Generic;
using System.Linq;
using Renting;


class MainClass {
    static void Main() {
        EmailValidator emailValidator = new EmailValidator();

        List<String> emails = new List<string> (new string[] { "notvalid.com",
        "valid@helloworld.com",
        "notvalid@test.co.uk",
        "notvalid@test.se",
        "valid@test.com",
        "valid@test.hr"});

        emails.ForEach(email => Console.WriteLine(email + "   Validity: " + emailValidator.IsValidAddress(email)));
        
        OutputSeparationLine();
    }


    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
