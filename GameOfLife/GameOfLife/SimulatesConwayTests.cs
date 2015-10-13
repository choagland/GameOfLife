using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway;

namespace GameOfLife
{
   [TestClass]
   public class SimulatesConwayTests
   {
      [TestMethod]
      public void ZeroIterations()
      {
         var seedBoard = new GameBoard(); 
         var mockRandomGameBoardGenerator = new Mock<IRandomGameBoardGenerator>();
         mockRandomGameBoardGenerator.Setup( g => g.generate( It.IsAny<int>(), It.IsAny<int>() ) ).Returns(seedBoard);
         var mockWorldOutputter = new Mock<IWorldOutputter>();

         var subject = new ConwaySimulator(mockRandomGameBoardGenerator.Object, mockWorldOutputter.Object);
         subject.Simulate(42, 42, 0);

         mockWorldOutputter.Verify( w => w.Output( seedBoard ) );
      }
   }
}
