using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Roll_Game.Game
{

    public class Die
    {
        private readonly Random _random;
        private const int SidesCount = 6;

        public Die(Random random)
        {
            _random = random;
        }

        public int Roll() => _random.Next(1, SidesCount + 1);

        public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");
    }
}
