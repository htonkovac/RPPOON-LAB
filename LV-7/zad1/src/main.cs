using System;
using System.Collections.Generic;
using LV7;


class MainClass
{
    static void Main()
    {
        double[] array = new double[] { 1, 5, 44, 7, 6, 8, 85, 678, 5, 4, 4, 367, 4, 74, 45, 76, 84, 6, 425, 2, 567, 4, 235, 5, 75, 86, 3, 5, 0, 233, 74, 734 };
        NumberSequence sequence1 = new NumberSequence(array);
        NumberSequence sequence2 = new NumberSequence(array);
        NumberSequence sequence3 = new NumberSequence(array);
        sequence1.SetSortStrategy(new BubbleSort());
        sequence2.SetSortStrategy(new CombSort());
        sequence3.SetSortStrategy(new SequentialSort());

        Console.WriteLine(sequence1);
        sequence1.Sort();
        Console.WriteLine(sequence1);

        OutputSeparationLine();

        Console.WriteLine(sequence2);
        sequence2.Sort();
        Console.WriteLine(sequence2);

        OutputSeparationLine();

        Console.WriteLine(sequence3);
        sequence3.Sort();
        Console.WriteLine(sequence3);


    }
    static void OutputSeparationLine()
    {
        System.Console.WriteLine("----------------------");
    }
}
