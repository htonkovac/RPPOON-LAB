using System;
using System.Collections.Generic;
using Dice;


/*
Izmijeniti klasu Die tako da koristi generator pseudo-slučajnih brojeva iz prethodnog primjera.
*/
class MainClass {
    static void Main() {
        int NUMBER_OF_DICE = 20;
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger(System.IO.Directory.GetCurrentDirectory() + "/log-result.txt");
        
        
        FlexibleDiceRoller flexibleRoller = new FlexibleDiceRoller();
        for (int i =0; i < NUMBER_OF_DICE; i++) {
            flexibleRoller.InsertDie(new Die(6));
        }
        flexibleRoller.RollAllDice();

        consoleLogger.Log(flexibleRoller);

        ClosedDiceRoller closedRoller = new ClosedDiceRoller(6,6);
        closedRoller.RollAllDice();
        fileLogger.Log(closedRoller);
    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
