using System;
using System.Collections.Generic;
using ToDo;


class MainClass {
    static void Main() {
        TodoListConsoleOutputer outputer = new TodoListConsoleOutputer();
        TodoList list = new TodoList();


        System.Console.WriteLine("Input Todo items and priorities");
        while (true) {
            System.Console.WriteLine("\nInput Note description or empty line to end:");
            
            String description = System.Console.ReadLine();
            if (description == "") {
                break;
            }

            System.Console.WriteLine("Input Note priority (1 = HIGHEST)");
            int priority = int.Parse(System.Console.ReadLine());
            Note item = new Note();
            item.description = description;
            item.priority = priority;

            list.AddItem(item);

        }

        OutputSeparationLine();

        outputer.OutputAllItems(list);
        OutputSeparationLine();

        List<Note> highPriorityItems = list.GetItemsWithPriorityOrHigher(1);
        foreach ( Note item in highPriorityItems) {
                item.Complete();
        }
        outputer.OutputAllItems(list);
        OutputSeparationLine();

    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}