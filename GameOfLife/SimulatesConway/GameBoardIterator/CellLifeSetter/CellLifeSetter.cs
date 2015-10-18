using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator.CellLifeSetter
{
   public class CellLifeSetter : ICellLifeSetter
   {
      public GameBoardCell SetLife( int numberOfLivingNeighbors, GameBoardCell cell )
      {
         bool wasAlive = cell.IsAlive;
         if ( numberOfLivingNeighbors <= 2 | numberOfLivingNeighbors > 3 )
         {
            cell.IsAlive = false;
         }
         if ( wasAlive && numberOfLivingNeighbors == 2 )
         {
            cell.IsAlive = true;
         }
         if ( numberOfLivingNeighbors == 3 )
         {
            cell.IsAlive = true;
         }
         return cell;
      }
   }
}
