using System.Collections.Generic;

namespace Chessington.GameEngine
{
    public static class Moves
    {
        public static List<Square> GetLateralMoves(Square boardLocation, List<Square> legalMoves)
        {
            for (var i = 0; i < 8; i++)
            {
                legalMoves.Add(Square.At(boardLocation.Row, i));
            }

            for (var i = 0; i < 8; i++)
            {
                legalMoves.Add(Square.At(i, boardLocation.Col));
            }
            
            //Get rid of our starting location.
            legalMoves.RemoveAll(s => s == Square.At(boardLocation.Row, boardLocation.Col));
            
            return legalMoves;
        }

        public static List<Square> RemoveOutOfBoundsMoves(Square boardLocation, List<Square> legalMoves)
        {
            // add code to remove out of bounds moves
            return legalMoves;
        }
    }
}