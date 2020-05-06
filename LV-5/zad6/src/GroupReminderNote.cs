using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class GroupReminderNote : Note
    {
        public List<string> people = new List<string>();
        public GroupReminderNote(string message, ITheme theme)
        : base(message, theme) { }

        public void AddPerson(string person)
        {
            this.people.Add(person);
        }
        public void RemovePerson(string person)
        {
            this.people.Remove(person);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            Console.WriteLine("For people:");
            this.people.ForEach(person => Console.WriteLine(person));

            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
