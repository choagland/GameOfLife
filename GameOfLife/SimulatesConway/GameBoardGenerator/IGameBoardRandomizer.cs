using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardGenerator
{
   public interface IGameBoardRandomizer
   {
      GameBoard Randomize( GameBoard emptyGameBoard );
   }
}
