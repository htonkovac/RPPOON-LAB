using System;
using System.Collections.Generic;
using ToDo;


class MainClass {
    static void Main() {
        TodoListConsoleOutputer outputer = new TodoListConsoleOutputer();
        TodoList list = new TodoList();


        System.Console.WriteLine("Input Todo items and priorities");
        while (true) {
            System.Console.WriteLine("\nInput todoitem description or empty line to end:");
            
            String description = System.Console.ReadLine();
            if (description == "") {
                break;
            }

            TodoItem item = new TodoItem();
            item.description = description;

            System.Console.WriteLine("Input todoitem priority (1 = HIGHEST)");
            int priority = int.Parse(System.Console.ReadLine());
            item.priority = priority;

            list.AddItem(item);

        }

        OutputSeparationLine();

        outputer.OutputAllItems(list);
        OutputSeparationLine();

        List<TodoItem> highPriorityItems = list.GetItemsWithPriorityOrHigher(1);
        foreach ( TodoItem item in highPriorityItems) {
                item.Complete();
        }
        outputer.OutputAllItems(list);
        OutputSeparationLine();

    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}