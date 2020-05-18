using System;
using System.Collections.Generic;
using LV7;


class MainClass
{
    static void Main()
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger("log.txt");
        SystemDataProvider dataProvider = new SystemDataProvider();
        dataProvider.Attach(fileLogger);
        dataProvider.Attach(consoleLogger);


        while (true)
        {
            dataProvider.GetCPULoad();
            dataProvider.GetAvailableRAM();
            System.Threading.Thread.Sleep(1000);
        }
    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
