using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardGenerator.GameBoardRandomizer
{
   public class GameBoardRandomizer : IGameBoardRandomizer
   {
      private ICellRandomizer _cellRandomizer;
      public GameBoardRandomizer( ICellRandomizer cellRandomizer )
      {
         _cellRandomizer = cellRandomizer;
      }

      public GameBoard Randomize( GameBoard gameBoard )
      {
         foreach ( var gameBoardCell in gameBoard.GameBoardCells )
         {
            _cellRandomizer.RandomizeCell( gameBoardCell );
         }
         return gameBoard;
      }
   }
}
