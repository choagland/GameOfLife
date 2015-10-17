using System;
using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardGenerator.GameBoardRandomizer.CellRandomizer
{
   public class CellRandomizer : ICellRandomizer
   {
      private readonly int _aliveLikelihood = 50;
      public GameBoardCell RandomizeCell( GameBoardCell cell )
      {
         var random = new Random();
         cell.IsAlive = random.Next(100) < _aliveLikelihood;
         return cell;
      }
   }
}
