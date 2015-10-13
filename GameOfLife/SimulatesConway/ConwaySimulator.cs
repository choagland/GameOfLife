using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatesConway
{
   public class ConwaySimulator
   {
      private readonly IRandomGameBoardGenerator _gameBoardGenerator;
      private readonly IWorldOutputter _worldOutputter;

      public ConwaySimulator( IRandomGameBoardGenerator randomGameBoardGenerator, IWorldOutputter worldOutputter )
      {
         // TODO: Complete member initialization
         _gameBoardGenerator = randomGameBoardGenerator;
         _worldOutputter = worldOutputter;
      }
      public void Simulate(int width, int height, int iterations)
      {
         GameBoard randomGameBoard = _gameBoardGenerator.generate( width, height );
         _worldOutputter.Output( randomGameBoard );
      }
   }
}
