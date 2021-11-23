using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            
            var boardLocation = board.FindPiece(this);
            var legalMoves = new List<Square>();
            legalMoves = Moves.GetDiagonalMoves(boardLocation, legalMoves);
            legalMoves = Moves.GetLateralMoves(boardLocation, legalMoves);
            return legalMoves;
        }
    }
}