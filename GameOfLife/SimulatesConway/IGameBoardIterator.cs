using SimulatesConway.ValueTypes;

namespace SimulatesConway
{
   public interface IGameBoardIterator
   {
      GameBoard Iterate( GameBoard previousGameBoard );
   }
}
