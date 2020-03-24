using System;
namespace LV1 {
    public class Note {
        public static int PRIORITY_LOW = 10;
        public static int PRIORITY_MEDIUM = 5;
        public static int PRIORITY_HIGH = 1;

        private int priority;
        private String description;
        private String author;
        public bool isComplete = false;


        public int Priority { 
            get { return priority; }
            set { this.priority = value; }
        }
        public String Description { 
            get { return description; }
            set { this.description = value; }
        }
        public String Author { get { return author; } }
        public bool IsComplete { 
            get { return isComplete; }
            set { this.isComplete = value; } }
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

        public Note() {
            this.priority = Note.PRIORITY_LOW;
            this.description = "Placeholder";
            this.author = "Unknown";
        }
        public Note(String description, String author, int priority) {
            this.priority = priority;
            this.description = description;
            this.author = author;
        }
        public Note(Note reference) {
            this.priority = reference.priority;
            this.description = reference.description;
            this.author = reference.author;
        }

        public override String ToString() {
            return $"{this.priority} : {this.GetCompletedStatus()} : {author} : {this.description}";
        }
    }
}
