using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimulatesConway;
using SimulatesConway.GameBoardGenerator;

namespace GameOfLife
{
   [TestClass]
   public class RandomGameGeneratorTests
   {
      [TestMethod]
      public void Randomize_ParentCallsGenerate_IsInvoked()
      {
         var randomizedGameboard = new GameBoard();
         var mockGameboardRandomizer = new Mock<IGameBoardRandomizer>();
         mockGameboardRandomizer.Setup( gbr => gbr.Randomize( It.IsAny<GameBoard>() ) ).Returns( randomizedGameboard );

         var subject = new RandomGameBoardGenerator();
         subject.generate( 42, 42 );

         mockGameboardRandomizer.Verify( gbr => gbr.Randomize( It.IsAny<GameBoard>() ) );
      }
   }
}
