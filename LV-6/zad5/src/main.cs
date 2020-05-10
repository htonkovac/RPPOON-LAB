using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
        AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
        FileLogger fileLogger =
        new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

        logger.Log("Console logging", MessageType.INFO);
        fileLogger.Log("File logging", MessageType.ERROR);
    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
