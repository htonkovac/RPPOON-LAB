using System;
using System.Collections.Generic;
using LV5;


class MainClass
{
    static void Main()
    {
        LightTheme lightTheme = new LightTheme();
        DarkTheme darkTheme = new DarkTheme();
        Notebook notebook = new Notebook(darkTheme);


        ReminderNote lightReminderNote = new ReminderNote("Moja svijetla poruka", lightTheme);
        GroupReminderNote groupReminderNote = new GroupReminderNote("Group message", darkTheme);
        groupReminderNote.AddPerson("Mark");
        groupReminderNote.AddPerson("John");
        groupReminderNote.AddPerson("Jane");

        notebook.AddNote(lightReminderNote);
        notebook.AddNote(groupReminderNote);

        notebook.Display();
        OutputSeparationLine();
        ReminderNote myNote = new ReminderNote("My note", lightTheme);

        notebook.AddNote(myNote);

        notebook.Display();
        OutputSeparationLine();

        notebook.ChangeTheme(lightTheme);
        notebook.Display();

    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------------------------------");
    }
}
