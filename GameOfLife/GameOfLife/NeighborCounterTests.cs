using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulatesConway.GameBoardIterator;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class NeighborCounterTests
   {
      private static GameBoardCell AliveCell()
      {
         return new GameBoardCell
         {
            IsAlive = true
         };
      }

      private static GameBoardCell DeadCell()
      {
         return new GameBoardCell
         {
            IsAlive = false
         };
      }

      [TestMethod]
      public void Count_TwoByTwoWithTwoAliveNeighbors_ReturnsTwo()
      {
         GameBoardCell[,] cells =
         {
            {
               DeadCell(), AliveCell()
            },
            {
               DeadCell(), AliveCell()
            }
         };
         var coordinates = new CellCoordinates
         {
            X = 0, Y = 0
         };

         var subject = new NeighborCounter();
         int count = subject.Count( cells, coordinates );

         count.Should().Be( 2 );
      }

      [TestMethod]
      public void Count_ThreeByThreeWithFourAliveNeighbors_ReturnsFour()
      {
         GameBoardCell[,] cells =
         {
            {
               DeadCell(), AliveCell(), AliveCell()
            },
            {
               DeadCell(), AliveCell(), AliveCell()
            },
            {
               DeadCell(), DeadCell(), AliveCell()
            }
         };
         var coordinates = new CellCoordinates
         {
            X = 1,
            Y = 1
         };

         var subject = new NeighborCounter();
         int count = subject.Count( cells, coordinates );

         count.Should().Be( 4 );
      }
   }
}
