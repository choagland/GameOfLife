namespace SimulatesConway
{
   public class ConwaySimulator
   {
      private readonly IGameBoardGenerator _gameBoardGenerator;
      private readonly IGameBoardIterator _gameBoardIterator;
      private readonly IGameBoardOutputter _gameBoardOutputter;

      public ConwaySimulator( IGameBoardGenerator gameBoardGenerator, IGameBoardIterator gameBoardIterator, IGameBoardOutputter gameBoardOutputter )
      {
         _gameBoardGenerator = gameBoardGenerator;
         _gameBoardIterator = gameBoardIterator;
         _gameBoardOutputter = gameBoardOutputter;
      }

      public void Simulate( int width, int height, int iterations )
      {
         var initialGameBoard = MakeInitialGameBoard( width, height );
         _gameBoardOutputter.Output( IterateGameBoards( iterations, initialGameBoard ) );
      }

      private GameBoard IterateGameBoards( int iterations, GameBoard initialGameBoard )
      {
         GameBoard iteratedGameBoard = initialGameBoard;
         for ( int i = 0; i < iterations; i++ )
         {
             iteratedGameBoard = _gameBoardIterator.Iterate( iteratedGameBoard );
         }
         return iteratedGameBoard;
      }

      private GameBoard MakeInitialGameBoard( int width, int height )
      {
         GameBoard randomGameBoard = _gameBoardGenerator.generate( width, height );
         return randomGameBoard;
      }
   }
}
