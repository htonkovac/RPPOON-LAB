using System;
using  ToDo;

class MainClass {
    static void Main() {
        TodoListConsoleOutputer outputer = new TodoListConsoleOutputer();
        TodoList list = new TodoList();


        System.Console.WriteLine("Input Todo items and priorities");
        while (true) {
            System.Console.WriteLine("Input todoitem description or empty line to end");
            description = System.Console.ReadLine();
            if (description == "") {
                break;
            }

            TodoItem item = new TodoItem();
            item.description = description;
        }

        outputer.OutputAllItems(list);

    }
}