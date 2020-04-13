using System;
using System.Collections.Generic;
using Dice;


/*
Izmijeniti klasu Die tako da koristi generator pseudo-slučajnih brojeva iz prethodnog primjera.
*/
class MainClass {
    static void Main() {
        int NUMBER_OF_DICE = 20;
        DiceRoller dr = new DiceRoller();
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger(System.IO.Directory.GetCurrentDirectory() + "/log-result.txt");

        for (int i =0; i < NUMBER_OF_DICE; i++) {
            dr.InsertDie(new Die(6));
        }
        dr.RollAllDice();

        consoleLogger.Log(dr);
        fileLogger.Log(dr);
    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
