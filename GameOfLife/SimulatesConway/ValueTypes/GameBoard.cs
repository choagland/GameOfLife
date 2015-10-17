namespace SimulatesConway.ValueTypes
{
   public class GameBoard
   {
      public GameBoard( int width, int height )
      {
         GameBoardCells = new GameBoardCell[width, height];
      }

      public GameBoardCell[,] GameBoardCells
      {
         get;
         set;
      }
   }
}
