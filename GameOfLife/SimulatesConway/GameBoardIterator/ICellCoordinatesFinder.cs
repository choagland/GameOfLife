using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public interface ICellCoordinatesFinder
   {
      CellCoordinates Find( GameBoardCell[,] gameBoardCells, GameBoardCell cell );
   }
}
