using System.Collections.Generic;
using System;
using System.Linq;

namespace ToDo
{
    public class TodoList {
        public List<TodoItem> items{ private set;  get; }

        public void AddItem(TodoItem item) {
            items.Add(item);
        }

        public void RemoveItem(TodoItem item) {
            items.Remove(item);
        }

        public TodoItem GetItem(int index) {
            return items[index];
        }

        public List<TodoItem> GetCompletedItems() {
            return items.Where( item => item.isComplete == true ).ToList();
        }

        public List<TodoItem> GetItemsWithPriorityOrHigher (int priority) {
            //Priority 1 is the highest priority. Priority 2 is lower than priority 1. Hence the function below has a less than operator
            return items.Where( item => item.priority <= priority).ToList();
        }

        public TodoList() {
            items = new List<TodoItem>();
        }
    }

    public class TodoItem {
        public int priority { set; get; }
        public bool isComplete = false;
        public String description { set; get; }

        public String GetCompletedStatus() {
            if (isComplete) {
                return "✅";
            } else {
                return "❌";
            }

        }
        public TodoItem Complete() {
            this.isComplete = true;
            return this;
        }
        public override String ToString() {
            return $"{priority}, {GetCompletedStatus()} : {description}";
        }
    }

    public interface ITodoListOutputer {
        void OutputAllItems(TodoList list);
        void OutputCompletedItems(TodoList list);
    }

    class TodoListConsoleOutputer : ITodoListOutputer{
        public void OutputAllItems(TodoList list) {
            foreach (TodoItem item in list.items) {
                System.Console.WriteLine(item);
            }
        }
        public void OutputCompletedItems(TodoList list) {
            foreach (TodoItem item in list.GetCompletedItems()) {
                System.Console.WriteLine(item);
            }
        }

    }

}