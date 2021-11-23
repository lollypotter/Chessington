using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var boardLocation = board.FindPiece(this);
            var legalMoves = new List<Square>();
            legalMoves = GetKnightMoves(boardLocation, legalMoves);
            return legalMoves;
        }

        private List<Square> GetKnightMoves(Square boardLocation, List<Square> legalMoves)
        {
            // check and add North to Left
            var newPosition = new Square(boardLocation.Row + 2, boardLocation.Col - 1);
            if (Moves.InBounds(newPosition))
            {
                legalMoves.Add(newPosition);
            }
            // check and add North to Right
            var newPosition2 = new Square(boardLocation.Row + 2, boardLocation.Col + 1);
            if (Moves.InBounds(newPosition2))
            {
                legalMoves.Add(newPosition2);
            }

            // check and add East at Top
            var newPosition3 = new Square(boardLocation.Row + 1, boardLocation.Col + 2);
            if (Moves.InBounds(newPosition3))
            {
                legalMoves.Add(newPosition3);
            }
            
            // check and add East at Bottom
            var newPosition4 = new Square(boardLocation.Row - 1, boardLocation.Col + 2);
            if (Moves.InBounds(newPosition4))
            {
                legalMoves.Add(newPosition4);
            }

            // check and add South to Left 
            var newPosition5 = new Square(boardLocation.Row - 2, boardLocation.Col - 1);
            if (Moves.InBounds(newPosition5))
            {
                legalMoves.Add(newPosition5);
            }
            
            // check and add South to Right
            var newPosition6 = new Square(boardLocation.Row - 2, boardLocation.Col + 1);
            if (Moves.InBounds(newPosition6))
            {
                legalMoves.Add(newPosition6);
            }
            
            //check and add West at Top
            var newPosition8 = new Square(boardLocation.Row + 1, boardLocation.Col - 2);
            if (Moves.InBounds(newPosition8))
            {
                legalMoves.Add(newPosition8);
            }
            
            //check and add West at Bottom
            var newPosition7 = new Square(boardLocation.Row - 1, boardLocation.Col - 2);
            if (Moves.InBounds(newPosition7))
            {
                legalMoves.Add(newPosition7);
            }
            return legalMoves;
        }
    }
}