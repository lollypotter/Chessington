using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var boardLocation = board.FindPiece(this);
            var legalMoves = new List<Square>();
            legalMoves = GetKingMoves(boardLocation, legalMoves);
            return legalMoves;
        }

        private List<Square> GetKingMoves(Square boardLocation, List<Square> legalMoves)
        {
             // check and add North
            var nPosition = new Square(boardLocation.Row + 1, boardLocation.Col);
            if (Moves.InBounds(nPosition))
            {
                legalMoves.Add(nPosition);
            }
            // check and add NW
            var nwPosition = new Square(boardLocation.Row + 1, boardLocation.Col - 1);
            if (Moves.InBounds(nwPosition))
            {
                legalMoves.Add(nwPosition);
            }

            // check and add NE
            var nePosition = new Square(boardLocation.Row + 1, boardLocation.Col + 1);
            if (Moves.InBounds(nePosition))
            {
                legalMoves.Add(nePosition);
            }
            
            // check and add E
            var ePosition = new Square(boardLocation.Row, boardLocation.Col + 1);
            if (Moves.InBounds(ePosition))
            {
                legalMoves.Add(ePosition);
            }

            // check and add W
            var wPosition = new Square(boardLocation.Row, boardLocation.Col - 1);
            if (Moves.InBounds(wPosition))
            {
                legalMoves.Add(wPosition);
            }
            
            // check and add South
            var sPosition = new Square(boardLocation.Row - 1, boardLocation.Col);
            if (Moves.InBounds(sPosition))
            {
                legalMoves.Add(sPosition);
            }
            
            //check and add SW
            var swPosition = new Square(boardLocation.Row - 1, boardLocation.Col - 1);
            if (Moves.InBounds(swPosition))
            {
                legalMoves.Add(swPosition);
            }
            
            //check and add SE
            var sePosition = new Square(boardLocation.Row - 1, boardLocation.Col + 1);
            if (Moves.InBounds(sePosition))
            {
                legalMoves.Add(sePosition);
            }
            return legalMoves;
        }
    }
}