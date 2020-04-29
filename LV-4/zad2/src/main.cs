using System;
using System.Collections.Generic;
using LV1;


class MainClass {
    static void Main() {
        Dataset data = new Dataset(System.AppDomain.CurrentDomain.BaseDirectory + "dataset.csv");
        Analyzer3rdParty analyzer = new Analyzer3rdParty();
        Adapter adapter = new Adapter(analyzer);

        double [] rowAverage = adapter.CalculateAveragePerRow(data);
        double [] columnAverage = adapter.CalculateAveragePerColumn(data);

        System.Console.WriteLine("Column Averages:");
        foreach (double n in columnAverage) {
            System.Console.Write(n + " ");
        }
        
        System.Console.WriteLine("\n----------------------");

        System.Console.WriteLine("Row Averages:");
        foreach (double n in rowAverage) {
            System.Console.WriteLine(n);
        }

    }
}
