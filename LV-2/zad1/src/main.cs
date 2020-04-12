using System;
using System.Collections.Generic;
using Dice;


/*
Kreirajte objekt klase DiceRoller i u njega ubacite 20 kockica. Baciti sve kockice i ispisati rezultate bacanja kockica na ekran. 
*/
class MainClass {
    static void Main() {
        int NUMBER_OF_DICE = 20;
        DiceRoller dr = new DiceRoller();
        
        for (int i =0; i < NUMBER_OF_DICE; i++) {
            dr.InsertDie(new Die(6));
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
