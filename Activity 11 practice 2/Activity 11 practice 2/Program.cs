using Activity_11_practice_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Chaz Pollino
//CST 150
// 6/4/23

//THIS IS MY OWN WORK

namespace Activtiy_11_practice_2
{
    class Program
    {
        public static void Main()
        {
            Dice die1 = new Dice(6);
            Dice die2 = new Dice(6);

            int Dice1roll, Dice2roll;
            int rolls = 0;



            do
            {
                Dice1roll = die1.rollDice();
                Dice2roll = die2.rollDice();
                Console.WriteLine("Rolled [ " + "Die1: " + Dice1roll + " Die2: " + Dice2roll + " ]");
                rolls++;

            }
            while (Dice1roll != 1 || Dice2roll != 1);
            Console.WriteLine("\n It Took The User " + rolls + " Rolls To Get A Pair Of Snake Eyes.");
            Console.ReadLine();
        }
    }
}