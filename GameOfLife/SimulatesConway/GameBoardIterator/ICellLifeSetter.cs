using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public interface ICellLifeSetter
   {
      GameBoardCell SetLife( int numberOfLivingNeighbors, GameBoardCell cell );
   }
}
