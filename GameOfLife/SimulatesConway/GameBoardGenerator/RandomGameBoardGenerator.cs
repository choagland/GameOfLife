namespace SimulatesConway.GameBoardGenerator
{
   public class RandomGameBoardGenerator : IGameBoardGenerator
   {
      private readonly IGameBoardRandomizer _gameBoardRandomizer;

      public RandomGameBoardGenerator( IGameBoardRandomizer gameBoardRandomizer )
      {
         _gameBoardRandomizer = gameBoardRandomizer;
      }
      public GameBoard generate( int width, int height )
      {
         var emptyGameBoard = new GameBoard();
         GameBoard randomizedGameBoard = _gameBoardRandomizer.Randomize( emptyGameBoard );
         return randomizedGameBoard;
      }
   }
}
