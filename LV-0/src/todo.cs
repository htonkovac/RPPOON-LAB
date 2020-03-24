using System.Collections.Generic;
using System;
using System.Linq;

namespace ToDo
{
    public class TodoList {
        public List<Note> items{ private set;  get; }

        public void AddItem(Note item) {
            items.Add(item);
        }

        public void RemoveItem(Note item) {
            items.Remove(item);
        }

        public Note GetItem(int index) {
            return items[index];
        }

        public List<Note> GetCompletedItems() {
            return items.Where( item => item.isComplete == true ).ToList();
        }

        public List<Note> GetItemsWithPriorityOrHigher (int priority) {
            //Priority 1 is the highest priority. Priority 2 is lower than priority 1. Hence the function below has a less than operator
            return items.Where( item => item.priority <= priority).ToList();
        }

        public TodoList() {
            items = new List<Note>();
        }
    }

    public class Note {
        public static int PRIORITY_LOW = 10;
        public static int PRIORITY_MEDIUM = 5;
        public static int PRIORITY_HIGH = 1;

        public int priority { set; get; }
        public bool isComplete = false;


        public String GetCompletedStatus() {
            if (isComplete) {
                return "✅";
            } else {
                return "❌";
            }
        }
        public Note Complete() {
            this.isComplete = true;
            return this;
        }
        public override String ToString() {
            return $"{priority}, {GetCompletedStatus()} : {description}";
        }

        Note() {
            this.priority = Note.PRIORITY_LOW; 
            this.description = "Placeholder";
            this.author = "Unknown";
        }
        Note(String author) {
            this.priority = Note.PRIORITY_LOW; 
            this.description = "Placeholder";
            this.author = author;
        }
        Note(String author, String description, int priority) {
            this.priority = priority;
            this.description = description;
            this.author = author;
        }
    }

    public interface ITodoListOutputer {
        void OutputAllItems(TodoList list);
        void OutputCompletedItems(TodoList list);
    }

    class TodoListConsoleOutputer : ITodoListOutputer{
        public void OutputAllItems(TodoList list) {
            foreach (Note item in list.items) {
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