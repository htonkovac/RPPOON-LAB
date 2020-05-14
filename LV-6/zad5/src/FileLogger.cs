using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;

        }
        protected override void WriteMessage(string message, MessageType type)
        {
            String log = $"{DateTime.Now} : {type} : {message}";
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true)) {
                writer.WriteLine(log);
            }
        }
    }
}
