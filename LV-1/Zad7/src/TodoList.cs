using System;
using System.Linq;
using System.Collections.Generic;

namespace LV1 {
    public class TodoList {
        public List<Note> Items{ private set;  get; }

        public void AddItem(Note item) {
            Items.Add(item);
        }

        public void RemoveItem(Note item) {
            Items.Remove(item);
        }

        public Note GetItem(int index) {
            return Items[index];
        }

        public List<Note> GetCompletedItems() {
            return Items.Where( item => item.IsComplete == true ).ToList();
        }

        public List<Note> GetItemsWithPriorityOrHigher (int priority) {
            //Priority 1 is the highest priority. Priority 2 is lower than priority 1. Hence the function below has a less than operator
            return Items.Where( item => item.Priority <= priority).ToList();
        }

        public TodoList() {
            Items = new List<Note>();
        }
    }

}