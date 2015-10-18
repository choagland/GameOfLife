using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public class GameBoardIterator : IGameBoardIterator
   {
      private readonly ICellCoordinatesFinder _cellCoordinatesFinder;
      private readonly INeighborCounter _neighborCounter;
      private readonly ICellLifeSetter _cellLifeSetter;

      public GameBoardIterator( ICellCoordinatesFinder cellCoordinatesFinder, INeighborCounter neighborCounter, ICellLifeSetter cellLifeSetter )
      {
         _cellCoordinatesFinder = cellCoordinatesFinder;
         _neighborCounter = neighborCounter;
         _cellLifeSetter = cellLifeSetter;
      }
      public GameBoard Iterate( GameBoard previousGameBoard )
      {
         GameBoardCell[,] gameBoardCells = previousGameBoard.GameBoardCells;
         foreach ( var gameBoardCell in previousGameBoard.GameBoardCells )
         {
            CellCoordinates coordinates = _cellCoordinatesFinder.Find( gameBoardCells, gameBoardCell );
            int aliveNeighbors = _neighborCounter.Count( gameBoardCells, coordinates );
            _cellLifeSetter.SetLife( aliveNeighbors, gameBoardCell );
         }
         return previousGameBoard;
      }
   }
}
