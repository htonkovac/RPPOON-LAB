using System;
namespace LV1 {
    public interface ITodoListOutputer {
        void OutputAllItems(TodoList list);
        void OutputCompletedItems(TodoList list);
    }
}