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

        OutputSeparationLine("virtualProxyDataset:");
        VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("sensitiveData.csv");
        printer.PrintDataset(virtualProxyDataset);

        OutputSeparationLine();

        User mark = User.GenerateUser("Mark");
        User john = User.GenerateUser("John");
        ProtectionProxyDataset johnProtectionProxyDataset = new ProtectionProxyDataset(mark);
        ProtectionProxyDataset markProtectionProxyDataset = new ProtectionProxyDataset(john);

        OutputSeparationLine("johnProtectionProxyDataset:");
        printer.PrintDataset(johnProtectionProxyDataset);

        OutputSeparationLine("markProtectionProxyDataset:");
        printer.PrintDataset(markProtectionProxyDataset);

        OutputSeparationLine();

    }
    static void OutputSeparationLine(string x = null)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("----------------------");
        System.Console.WriteLine(x);
    }
}
