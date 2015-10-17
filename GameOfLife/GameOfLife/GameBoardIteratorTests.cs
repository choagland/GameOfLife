using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway.GameBoardIterator;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class GameBoardIteratorTests
   {
      [TestMethod]
      public void Iterate_CountsNeighbors()
      {
         var mockNeighborCounter = new Mock<INeighborCounter>();
         var gameBoard = new GameBoard( 3, 5 );

         var subject = new GameBoardIterator();
         subject.Iterate( gameBoard );

         mockNeighborCounter.Verify( nc => nc.Count( It.IsAny<GameBoardCell[,]>(), It.IsAny<int>(), It.IsAny<int>() ), Times.Exactly(15) );
      }

      [TestMethod]
      public void Iterate_SetsCellsLives()
      {
         var mockCellLifeSetter = new Mock<ICellLifeSetter>();
         var gameBoard = new GameBoard( 3, 5 );

         var subject = new GameBoardIterator();
         subject.Iterate( gameBoard );

         mockCellLifeSetter.Verify( cls => cls.SetLife( It.IsAny<int>(), It.IsAny<GameBoardCell>() ), Times.Exactly( 15 ) );
      }
   }
}
