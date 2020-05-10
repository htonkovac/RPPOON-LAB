using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
        Note note1 = new Note("Shopping list", "Cookies, Milk, Eggs, Water");
        Note note2 = new Note("Movies list", "Star Wars, Bee Movie, Avengers");
        Note note3 = new Note("Hello World", "Hello Earth, Hello Mars, Hello Venus");
        Notebook notebook = new Notebook();

        notebook.AddNote(note1);
        notebook.AddNote(note2);
        notebook.AddNote(note3);
        notebook.RemoveNote(note3);

        IAbstractIterator notebookIterator = notebook.GetIterator();

        
        while (!notebookIterator.IsDone) {
            notebookIterator.Current.Show();
            notebookIterator.Next();
        }



    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
