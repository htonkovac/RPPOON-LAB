using System;
using System.Collections.Generic;
using LV5;


class MainClass
{
    static void Main()
    {
        LightTheme lightTheme = new LightTheme();
        DarkTheme darkTheme = new DarkTheme();


        GroupReminderNote groupReminderNote = new GroupReminderNote("Group message", lightTheme);
        groupReminderNote.AddPerson("Mark");
        groupReminderNote.AddPerson("John");
        groupReminderNote.AddPerson("Jane");

        groupReminderNote.Show();

        groupReminderNote.Theme = darkTheme;
        groupReminderNote.RemovePerson("John");
        groupReminderNote.Show();

    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
