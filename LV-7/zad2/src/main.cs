using System;
using System.Collections.Generic;
using LV7;


class MainClass
{
    static void Main()
    {
        double[] array = new double[] { 1, 5, 44, 7, 6, 8, 85, 678, 5, 4, 4, 367, 4, 74, 45, 76, 84, 6, 425, 2, 567, 4, 235, 5, 75, 86, 3, 5, 0, 233, 74, 734 };
        NumberSequence sequence = new NumberSequence(array);

        sequence.SetSortStrategy(new BubbleSort());
        sequence.SetSearchStrategy(new LinearSearch());
        int numberToSerachFor = 7;
        Console.WriteLine(sequence.Search(numberToSerachFor));
        sequence.Sort();
        Console.WriteLine(sequence.Search(numberToSerachFor));
    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
