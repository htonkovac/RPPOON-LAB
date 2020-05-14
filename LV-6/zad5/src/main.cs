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


        logger.Log("Log logging level 1", MessageType.INFO);
        logger.Log("Log logging level 2", MessageType.WARNING);
        logger.Log("Log logging level 3", MessageType.ERROR);
    }
    static void OutputLineSeparator()
    {
        System.Console.WriteLine("----------------------");
    }
}
