using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway.GameBoardGenerator.GameBoardRandomizer;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class GameBoardRandomizerTests
   {
      [TestMethod]
      public void Randomize_CalledWithGameBoard_RandomizesEveryCell()
      {
         var gameboard = new GameBoard( 3, 5 );
         var mockCellRandomizer = new Mock<ICellRandomizer>();

         var subject = new GameBoardRandomizer( mockCellRandomizer.Object );
         subject.Randomize( gameboard );

         mockCellRandomizer.Verify( cr => cr.RandomizeCell( It.IsAny<GameBoardCell>() ), Times.Exactly( 15 ) );
      }
   }
}
