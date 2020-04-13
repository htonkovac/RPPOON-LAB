using System;
using System.Collections.Generic;
using Dice;


/*
Izmijeniti klasu Die tako da koristi generator pseudo-slučajnih brojeva iz prethodnog primjera.
*/
class MainClass {
    static void Main() {
        int NUMBER_OF_DICE = 20;
        DiceRoller roller = new DiceRoller();
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger(System.IO.Directory.GetCurrentDirectory() + "/log-result.txt");

        for (int i =0; i < NUMBER_OF_DICE; i++) {
            roller.InsertDie(new Die(6));
        }
        roller.RollAllDice();

        consoleLogger.Log(roller);
        fileLogger.Log(roller);
    }

}
