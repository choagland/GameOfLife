﻿using SimulatesConway.ValueTypes;

namespace SimulatesConway
{
   public interface IGameBoardGenerator
   {
      GameBoard generate( int width, int height );
   }
}
