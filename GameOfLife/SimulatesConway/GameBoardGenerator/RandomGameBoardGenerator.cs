using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatesConway.GameBoardGenerator
{
   public class RandomGameBoardGenerator : IGameBoardGenerator
   {
      public GameBoard generate( int width, int height )
      {
         var gameBoard = new GameBoard();
         return gameBoard;
      }
   }
}
