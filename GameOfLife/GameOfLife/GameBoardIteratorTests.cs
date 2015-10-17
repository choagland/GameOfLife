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
      public void Iterate_FindsCellCoordinates()
      {
         var mockCellCoordinateFinder = new Mock<ICellCoordinatesFinder>();
         var mockNeighborCounter = new Mock<INeighborCounter>();
         var mockCellifeSetter = new Mock<ICellLifeSetter>();
         var gameBoard = new GameBoard( 3, 5 );

         var subject = new GameBoardIterator( mockCellCoordinateFinder.Object, mockNeighborCounter.Object, mockCellifeSetter.Object );
         subject.Iterate( gameBoard );

         mockCellCoordinateFinder.Verify( ccf => ccf.Find( gameBoard.GameBoardCells, It.IsAny<GameBoardCell>() ), Times.Exactly( 15 ) );

      }

      [TestMethod]
      public void Iterate_CountsNeighbors()
      {
         var mockCellCoordinateFinder = new Mock<ICellCoordinatesFinder>();
         var mockNeighborCounter = new Mock<INeighborCounter>();
         var mockCellifeSetter = new Mock<ICellLifeSetter>();
         var gameBoard = new GameBoard( 3, 5 );

         var subject = new GameBoardIterator( mockCellCoordinateFinder.Object, mockNeighborCounter.Object, mockCellifeSetter.Object );
         subject.Iterate( gameBoard );

         mockNeighborCounter.Verify( nc => nc.Count( It.IsAny<GameBoardCell[,]>(), It.IsAny<CellCoordinates>() ), Times.Exactly( 15 ) );
      }

      [TestMethod]
      public void Iterate_SetsCellsLives()
      {
         var mockCellCoordinateFinder = new Mock<ICellCoordinatesFinder>();
         var mockNeighborCounter = new Mock<INeighborCounter>();
         var mockCellLifeSetter = new Mock<ICellLifeSetter>();
         var gameBoard = new GameBoard( 3, 5 );

         var subject = new GameBoardIterator( mockCellCoordinateFinder.Object, mockNeighborCounter.Object, mockCellLifeSetter.Object );
         subject.Iterate( gameBoard );

         mockCellLifeSetter.Verify( cls => cls.SetLife( It.IsAny<int>(), It.IsAny<GameBoardCell>() ), Times.Exactly( 15 ) );
      }

   }
}
