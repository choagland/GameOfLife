using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulatesConway.GameBoardIterator.CellLifeSetter;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class CellLifeSetterTests
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
      public void SetLife_LiveCellOneNeighbor_Dies()
      {
         GameBoardCell cell = AliveCell();

         var subject = new CellLifeSetter();
         subject.SetLife( 1, cell );

         cell.IsAlive.Should().BeFalse( "it should die of hunger." );
      }

      [TestMethod]
      public void SetLife_LiveCellFourNeighbors_Dies()
      {
         GameBoardCell cell = AliveCell();

         var subject = new CellLifeSetter();
         subject.SetLife( 4, cell );

         cell.IsAlive.Should().BeFalse( "it should die of overpopulation." );
      }

      [TestMethod]
      public void SetLife_LiveCellTwoNeighbors_Lives()
      {
         GameBoardCell cell = AliveCell();

         var subject = new CellLifeSetter();
         subject.SetLife( 2, cell );

         cell.IsAlive.Should().BeTrue( );
      }

      [TestMethod]
      public void SetLife_DeadCellTwoNeighbors_StaysDead()
      {
         GameBoardCell cell = DeadCell();

         var subject = new CellLifeSetter();
         subject.SetLife( 2, cell );

         cell.IsAlive.Should().BeFalse("two is not enough to raise dead cells to life");
      }

      [TestMethod]
      public void SetLife_DeadCellThreeNeighbors_Resurrects()
      {
         GameBoardCell cell = DeadCell();

         var subject = new CellLifeSetter();
         subject.SetLife( 3, cell );

         cell.IsAlive.Should().BeTrue( "three is enough to raise dead cells to life" );
      }


   }
}
