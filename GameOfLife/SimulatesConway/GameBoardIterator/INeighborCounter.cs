using SimulatesConway.GameBoardGenerator.GameBoardRandomizer.CellRandomizer;

namespace SimulatesConway.GameBoardIterator
{
   public interface INeighborCounter
   {
      int Count( CellRandomizer[,] gameBoardCells, int xPosition, int yPosition );
   }
}
