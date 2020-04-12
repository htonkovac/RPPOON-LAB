using System;

namespace Dice {
    class ConsoleLogger : ILogger {
        public void Log(string message) {
            Console.WriteLine(message);
        }
    }
}

