using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator
{
   public interface ICellCoordinatesFinder
   {
      CellCoordinates Find( GameBoardCell[,] gameBoardCells, GameBoardCell cell );
   }
}
