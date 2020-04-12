using System;
using System.Collections.Generic;
using Dice;


/*
Izmijeniti klasu Die tako da joj se preko konstruktora predaje generator pseudo-slučajnih brojeva. Ponoviti zadatak 1.
*/
class MainClass {
    static void Main() {
        int NUMBER_OF_DICE = 20;
        DiceRoller dr = new DiceRoller();
         Random randomGenerator = new Random();
        for (int i =0; i < NUMBER_OF_DICE; i++) {
            dr.InsertDie(new Die(6, randomGenerator));
        }
        dr.RollAllDice();
        IList<int> rollResults = dr.GetRollingResults();
        foreach (int rollResult in rollResults) {
            System.Console.WriteLine(rollResult);   
        }
    }

    static void OutputSeparationLine() {
        System.Console.WriteLine("----------------------");
    }
}
