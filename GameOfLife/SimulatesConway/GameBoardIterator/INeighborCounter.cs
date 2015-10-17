

using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public interface INeighborCounter
   {
      int Count( GameBoardCell[,] gameBoardCells, int xPosition, int yPosition );
   }
}
