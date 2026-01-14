using Dice_Roll_Game.Game;

var random = new Random();
var die = new Die(random);
var guessingGame = new GuessingGame(die);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);


Console.ReadKey();