using System;

namespace Dice {
    class FileLogger : ILogger {
        private string filePath;


        public FileLogger(string path) {
            this.filePath = path;
        }
        public void Log(string message) {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath)) {
                writer.WriteLine(message);
            }
        }
    }
}

