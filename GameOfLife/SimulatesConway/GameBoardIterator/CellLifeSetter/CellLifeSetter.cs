using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatesConway.ValueTypes;

namespace SimulatesConway.GameBoardIterator.CellLifeSetter
{
   public class CellLifeSetter : ICellLifeSetter
   {
      public GameBoardCell SetLife( int numberOfLivingNeighbors, GameBoardCell cell )
      {
         if ( numberOfLivingNeighbors <= 2 | numberOfLivingNeighbors > 3 )
         {
            cell.IsAlive = false;
         }
         //if (cell.IsAlive && numberOfLivingNeighbors == 2)
         //{
         //   cell.IsAlive = true;
         //}
         //if (numberOfLivingNeighbors == 3)
         //{
         //   cell.IsAlive = true;
         //}
         return cell;
      }
   }
}
