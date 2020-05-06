using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class Notebook
    {
        private List<Note> notes;
        private ITheme theme;
        public Notebook(ITheme theme) { 
            this.theme = theme;
            this.notes = new List<Note>(); 
            }
        public void AddNote(Note note) { 
            note.Theme = this.theme;
            this.notes.Add(note); 
            }

        public void ChangeTheme(ITheme theme)
        {
            this.theme = theme;
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
