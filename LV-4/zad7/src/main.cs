using System;
using System.Collections.Generic;
using System.Linq;
using Renting;

class MainClass
{
    static void Main()
    {
        RegistrationValidator registrationValidator = new RegistrationValidator();
        UserEntry userEntry;
        do
        {
            userEntry = UserEntry.ReadUserFromConsole();
        }
        while (!registrationValidator.IsUserEntryValid(userEntry));


        System.Console.WriteLine("SUCCESS");
    }


    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
