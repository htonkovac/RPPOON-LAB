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
        roller.logger = new ConsoleLogger();
        
        for (int i =0; i < NUMBER_OF_DICE; i++) {
            roller.InsertDie(new Die(6));
        }
        roller.RollAllDice();
        roller.LogRollingResults();
        roller.logger = new FileLogger(System.IO.Directory.GetCurrentDirectory() + "/log-result.txt");
        roller.LogRollingResults();

    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
