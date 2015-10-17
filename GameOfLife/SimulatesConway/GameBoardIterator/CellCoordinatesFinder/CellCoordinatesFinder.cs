using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator.CellCoordinatesFinder
{
   public class CellCoordinatesFinder :ICellCoordinatesFinder
   {
      public CellCoordinates Find( GameBoardCell[,] gameBoardCells, GameBoardCell cell )
      {
         int w = gameBoardCells.GetLength( 0 ); // width
         int h = gameBoardCells.GetLength( 1 ); // height

         for ( int x = 0; x < w; ++x )
         {
            for ( int y = 0; y < h; ++y )
            {
               if ( gameBoardCells[x, y].Equals( cell ) )
               {
                  return new CellCoordinates
                  {
                     X = x, Y = y
                  };
               }
                  
            }
         }
         throw new KeyNotFoundException();
      }
   }
}
