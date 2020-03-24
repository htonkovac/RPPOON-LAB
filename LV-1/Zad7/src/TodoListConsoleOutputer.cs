using System;
namespace LV1 {
    class TodoListConsoleOutputer : ITodoListOutputer{
        public void OutputAllItems(TodoList list) {
            foreach (Note item in list.Items) {
                System.Console.WriteLine(item);
            }
        }
        public void OutputCompletedItems(TodoList list) {
            foreach (Note item in list.GetCompletedItems()) {
                System.Console.WriteLine(item);
            }
        }

    }

}