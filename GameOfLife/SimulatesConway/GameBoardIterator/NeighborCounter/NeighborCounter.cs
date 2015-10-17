using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator.NeighborCounter
{
   public class NeighborCounter : INeighborCounter
   {
      public int Count( GameBoardCell[,] gameBoardCells, CellCoordinates coordinates )
      {
         int numberOfLivingNeighbors = 0;
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X - 1, coordinates.Y - 1 );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X - 1, coordinates.Y );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X - 1, coordinates.Y + 1 );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X , coordinates.Y - 1 );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X, coordinates.Y + 1 );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X + 1, coordinates.Y - 1 );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X + 1, coordinates.Y );
         numberOfLivingNeighbors += PlusOneIfCellIsAlive( gameBoardCells, coordinates.X + 1, coordinates.Y + 1 );
         return numberOfLivingNeighbors;
      }

      private int PlusOneIfCellIsAlive( GameBoardCell[,] gameBoardCells, int xPosition, int yPosition )
      {
         int height = gameBoardCells.GetLength( 0 );
         int width = gameBoardCells.GetLength( 1 );
         if ( xPosition < 0 | xPosition > height | yPosition < 0 | yPosition > width)
         {
            return 0;
         }
         if ( gameBoardCells[xPosition, yPosition].IsAlive )
         {
            return 1;
         }
            return 0;
      }
   }
}
