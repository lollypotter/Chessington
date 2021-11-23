using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            legalMoves = GetLegalMoves(boardLocation, legalMoves);
            return legalMoves;
        }

        private List<Square> GetLegalMoves(Square boardLocation, List<Square> legalMoves)
        {
            switch (Player)
            {
                case Player.Black when boardLocation.Row != 1: //moves up one square
                    legalMoves.Add(new Square(boardLocation.Row + 1, boardLocation.Col));
                    return legalMoves;
                case Player.Black when boardLocation.Row == 1: //moves up one or two squares
                    legalMoves.Add(new Square(boardLocation.Row + 2, boardLocation.Col));
                    legalMoves.Add(new Square(boardLocation.Row + 1, boardLocation.Col));
                    return legalMoves;
                case Player.White when boardLocation.Row != 7: // moves down one square
                    legalMoves.Add(new Square(boardLocation.Row - 1, boardLocation.Col));
                    return legalMoves;
                case Player.White when boardLocation.Row == 7: //moves down one or two squares
                    legalMoves.Add(new Square(boardLocation.Row - 2, boardLocation.Col));
                    legalMoves.Add(new Square(boardLocation.Row - 1, boardLocation.Col));
                    return legalMoves;
            }
            return legalMoves;
        }
    }
}