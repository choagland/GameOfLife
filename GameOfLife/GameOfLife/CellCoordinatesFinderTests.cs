using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulatesConway.GameBoardIterator.CellCoordinatesFinder;
using SimulatesConway.ValueTypes;
using FluentAssertions;

namespace GameOfLife
{
   [TestClass]
   public class CellCoordinatesFinderTests
   {
      [TestMethod]
      public void Find_ArrayWithCell_ReportsProperCoordinates()
      {
         var cellToFind = new GameBoardCell();
         GameBoardCell[,] cells =
         {
            {
               new GameBoardCell(), new GameBoardCell(), new GameBoardCell()
            },
            {
               new GameBoardCell(), new GameBoardCell(), new GameBoardCell()
            },
            {
               cellToFind, new GameBoardCell(), new GameBoardCell()
            },
            {
               new GameBoardCell(), new GameBoardCell(), new GameBoardCell()
            },
            {
               new GameBoardCell(), new GameBoardCell(), new GameBoardCell()
            }
         };

         var subject = new CellCoordinatesFinder();
         CellCoordinates coordinates = subject.Find( cells, cellToFind );

         coordinates.X.Should().Be( 2 );
         coordinates.Y.Should().Be( 0 );
      }
   }
}
