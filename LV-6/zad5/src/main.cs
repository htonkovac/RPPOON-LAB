using System;
using System.Collections.Generic;
using LV6;


class MainClass
{
    static void Main()
    {
        AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
        FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
        logger.SetNextLogger(fileLogger);


        logger.Log("Console logging", MessageType.INFO);
        logger.Log("File logging", MessageType.ERROR);
    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
