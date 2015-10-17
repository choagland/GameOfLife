using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardGenerator.GameBoardRandomizer
{
   public interface ICellRandomizer
   {
      GameBoardCell RandomizeCell( GameBoardCell cell );
   }
}
