using System;

namespace Dice {
    class ConsoleLogger : ILogger {
        public void Log(ILogable data) {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}

