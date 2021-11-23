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

        public static List<Square> GetDiagonalMoves(Square boardLocation, List<Square> legalMoves)
        {
            for (var i = 0; i < 8; i++)
            {
                var newPosition = new Square(boardLocation.Row + i, boardLocation.Col + i);
                
                // check top right diagonal
                if (newPosition != boardLocation & newPosition.Row < 8  & newPosition.Col < 8)
                {
                    legalMoves.Add(newPosition);
                }
                // check top left diagonal
                newPosition = new Square(boardLocation.Row + i, boardLocation.Col - i);
                if (newPosition != boardLocation & newPosition.Row < 8 & newPosition.Col >= 0)
                {
                    legalMoves.Add(newPosition);
                }
                // check bottom right diagonal
                newPosition = new Square(boardLocation.Row - i, boardLocation.Col + i);
                if (newPosition != boardLocation & newPosition.Row >= 0 & newPosition.Col < 8)
                {
                    legalMoves.Add(newPosition);
                }
                //check bottom left diagonal
                newPosition = new Square(boardLocation.Row - i, boardLocation.Col - i);
                if (newPosition != boardLocation & newPosition.Row >= 0 & newPosition.Col >= 0)
                {
                    legalMoves.Add(newPosition);
                }
            }
           
            return legalMoves;
        }
    }
}