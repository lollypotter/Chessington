using System.Collections.Generic;
using System.Linq;
using Chessington.GameEngine;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var boardLocation = board.FindPiece(this);
            var legalMoves = new List<Square>();
            legalMoves = Moves.GetLateralMoves(boardLocation, legalMoves);

            return legalMoves;
        }
        
    }
}