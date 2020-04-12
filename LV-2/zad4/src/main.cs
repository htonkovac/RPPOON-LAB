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
        dr.logger = new ConsoleLogger();
        
        for (int i =0; i < NUMBER_OF_DICE; i++) {
            dr.InsertDie(new Die(6));
        }
        dr.RollAllDice();
        dr.LogRollingResults();
        dr.logger = new FileLogger(System.IO.Directory.GetCurrentDirectory() + "/log-result.txt");
        dr.LogRollingResults();

    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
