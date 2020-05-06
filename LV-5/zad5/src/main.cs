using System;
using System.Collections.Generic;
using LV5;


class MainClass {
    static void Main() {
        LightTheme lightTheme = new LightTheme();
        ReminderNote lightReminderNote = new ReminderNote("Moja svijetla poruka",lightTheme);
        lightReminderNote.Show();

        DarkTheme darkTheme = new DarkTheme();
        ReminderNote darkReminderNote = new ReminderNote("Moja tamna poruka",darkTheme);
        darkReminderNote.Show();
    
    }
    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
