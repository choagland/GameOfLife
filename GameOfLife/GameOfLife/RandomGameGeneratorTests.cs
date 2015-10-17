using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway.GameBoardGenerator;
using SimulatesConway.ValueTypes;

namespace GameOfLife
{
   [TestClass]
   public class RandomGameGeneratorTests
   {
      [TestMethod]
      public void Randomize_ParentCallsGenerate_IsInvoked()
      {
         var randomizedGameboard = new GameBoard(42, 42);
         var mockGameboardRandomizer = new Mock<IGameBoardRandomizer>();
         mockGameboardRandomizer.Setup( gbr => gbr.Randomize( It.IsAny<GameBoard>() ) ).Returns( randomizedGameboard );

         var subject = new RandomGameBoardGenerator( mockGameboardRandomizer.Object );
         subject.generate( 42, 42 );

         mockGameboardRandomizer.Verify( gbr => gbr.Randomize( It.IsAny<GameBoard>() ) );
      }
   }
}
