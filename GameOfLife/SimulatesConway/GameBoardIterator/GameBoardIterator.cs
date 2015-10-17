using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public class GameBoardIterator : IGameBoardIterator
   {
      private INeighborCounter _neighborCounter;
      private ICellLifeSetter _cellLifeSetter;
      public GameBoard Iterate( GameBoard previousGameBoard )
      {
         foreach ( var gameBoardCell in previousGameBoard.GameBoardCells )
         {
            
         }
         return previousGameBoard;
      }
   }
}
