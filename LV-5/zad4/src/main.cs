using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LV5;


class MainClass
{
    static void Main()
    {
        DataConsolePrinter printer = new DataConsolePrinter();

        OutputSeparationLine("regular dataset:");
        Dataset dataset = new Dataset("sensitiveData.csv");
        printer.PrintDataset(dataset);

        OutputSeparationLine("logging dataset:");
        LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset("sensitiveData.csv");
        printer.PrintDataset(loggingProxyDataset);

        OutputSeparationLine();

    }
    static void OutputSeparationLine(string x = null)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("----------------------");
        System.Console.WriteLine(x);
    }
}
