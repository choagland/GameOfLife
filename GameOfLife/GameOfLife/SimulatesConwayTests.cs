using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class SimulatesConwayTests
   {
      [TestMethod]
      public void ZeroIterations()
      {
         var seedBoard = new GameBoard(42, 42);
         var mockGameBoardGenerator = new Mock<IGameBoardGenerator>();
         mockGameBoardGenerator.Setup( g => g.generate( It.IsAny<int>(), It.IsAny<int>() ) ).Returns( seedBoard );
         var mockWorldOutputter = new Mock<IGameBoardOutputter>();

         var subject = new ConwaySimulator( mockGameBoardGenerator.Object, new Mock<IGameBoardIterator>().Object, mockWorldOutputter.Object );
         subject.Simulate( 42, 42, 0 );

         mockWorldOutputter.Verify( w => w.Output( seedBoard ) );
      }

      [TestMethod]
      public void OneIteration()
      {
         var seedBoard = new GameBoard(42, 42);
         var iteratedBoard = new GameBoard(42, 42);
         var mockGameBoardGenerator = new Mock<IGameBoardGenerator>();
         mockGameBoardGenerator.Setup( g => g.generate( It.IsAny<int>(), It.IsAny<int>() ) ).Returns( seedBoard );
         var mockGameBoardIterator = new Mock<IGameBoardIterator>();
         mockGameBoardIterator.Setup( gbi => gbi.Iterate( seedBoard ) ).Returns( iteratedBoard );
         var mockWorldOutputter = new Mock<IGameBoardOutputter>();

         var subject = new ConwaySimulator( mockGameBoardGenerator.Object, mockGameBoardIterator.Object, mockWorldOutputter.Object );
         subject.Simulate( 42, 42, 1 );

         mockWorldOutputter.Verify( o => o.Output( iteratedBoard ) );
      }

      [TestMethod]
      public void TwoIterations()
      {
         var seedBoard = new GameBoard(42, 42);
         var iteratedBoard1 = new GameBoard( 42, 42 );
         var iteratedBoard2 = new GameBoard( 42, 42 );
         var mockGameBoardGenerator = new Mock<IGameBoardGenerator>();
         mockGameBoardGenerator.Setup( g => g.generate( It.IsAny<int>(), It.IsAny<int>() ) ).Returns( seedBoard );
         var mockGameBoardIterator = new Mock<IGameBoardIterator>();
         mockGameBoardIterator.Setup( gbi => gbi.Iterate( seedBoard ) ).Returns( iteratedBoard1 );
         mockGameBoardIterator.Setup( gbi => gbi.Iterate( iteratedBoard1 ) ).Returns( iteratedBoard2 );
         var mockWorldOutputter = new Mock<IGameBoardOutputter>();

         var subject = new ConwaySimulator( mockGameBoardGenerator.Object, mockGameBoardIterator.Object, mockWorldOutputter.Object );
         subject.Simulate( 42, 42, 2 );

         mockWorldOutputter.Verify( o => o.Output( iteratedBoard2 ) );
      }
   }
}
