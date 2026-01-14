using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Roll_Game.Game
{
    public class GuessingGame
    {
        private readonly Die _die;
        private const int InitialTries = 3;

        public GuessingGame(Die die)
        {
            _die = die;
        }

        public GameResult Play()
        {
            var diceRollResult = _die.Roll();
            Console.WriteLine(
                $"Dice rolled. Guess what number it shows in {InitialTries} tries");

            var triesLeft = InitialTries;
            while (triesLeft > 0) 
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                -- triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "you win!"
                : "You lose :(";

            Console.WriteLine(message);
        }
    }
}
