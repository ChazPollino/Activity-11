using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Chaz Pollino
//CST 150
// 6/4/23

//THIS IS MY OWN WORK

namespace Activity_11_practice_2
    
{
    public class Dice
    {
        private int NUMBER_OF_SIDES;
        private static Random Dice_Face = new Random();

        public Dice (int NUMBER_OF_SIDES)
        {
            if (NUMBER_OF_SIDES > 4 || NUMBER_OF_SIDES > 20)
            {
                Console.WriteLine("Number Should Be Inbetween 4 and 20");

            }
            this.NUMBER_OF_SIDES = NUMBER_OF_SIDES;
        }

        public int rollDice()
        {

            return Dice_Face.Next(1, NUMBER_OF_SIDES + 1);
        }
    }
}
