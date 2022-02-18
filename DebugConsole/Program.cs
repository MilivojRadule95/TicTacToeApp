
using TicTacToeLibrary;

TicTacToeGame game = new TicTacToeGame();
game.NewGame();

Console.WriteLine(game);

while (game.IsGameOver() == false) 
{   
    game.MakeAMove(Convert.ToInt32( Console.ReadLine()));
    Console.Clear();
    Console.WriteLine(game.ToString());
}