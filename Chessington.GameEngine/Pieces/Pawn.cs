using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var boardLocation = board.FindPiece(this);
            var legalMoves = new List<Square>();
            GetLegalMoves(boardLocation, legalMoves);

            return legalMoves;
        }

        private void GetLegalMoves(Square boardLocation, List<Square> legalMoves)
        {
            switch (Player)
            {
                case Player.White:     //moves down one square
                    legalMoves.Add(new Square(boardLocation.Row - 1, boardLocation.Col));
                    break;
                case Player.Black:     //moves up one square
                 legalMoves.Add(new Square(boardLocation.Row + 1, boardLocation.Col));
                 break;
        
            }
        }
    }
}