using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    abstract class AbstractLogger
    {
        protected MessageType messageTypeHandling;
        protected AbstractLogger nextLogger;

        public AbstractLogger(MessageType messageType)
        {
            this.messageTypeHandling = messageType;
        }
        public void SetNextLogger(AbstractLogger logger)
        {
            this.nextLogger = logger;
        }
        public void Log(string message, MessageType type)
        {
            if ((type & this.messageTypeHandling) != 0)
            {
                this.WriteMessage(message, type);
            }
            if (this.nextLogger != null)
            {
                this.nextLogger.Log(message, type);
            }
        }

        protected abstract void WriteMessage(string message, MessageType type);
    }
}
