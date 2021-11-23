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
            if (Player == Player.Black)
            {
                switch (boardLocation.Row)
                {
                    case 1: //moves up one or two squares
                        legalMoves.Add(new Square(boardLocation.Row + 2, boardLocation.Col));
                        legalMoves.Add(new Square(boardLocation.Row + 1, boardLocation.Col));
                        return legalMoves;
                    default:                  // if not 1, moves up one square
                        legalMoves.Add(new Square(boardLocation.Row + 1, boardLocation.Col));
                        return legalMoves;
                }
            }
            else
            {
                switch (boardLocation.Row)
                {
                    case 6: //moves down one or two squares
                        legalMoves.Add(new Square(boardLocation.Row - 2, boardLocation.Col));
                        legalMoves.Add(new Square(boardLocation.Row - 1, boardLocation.Col));
                        return legalMoves;
                    default: // if not 6 moves down one square 
                        legalMoves.Add(new Square(boardLocation.Row - 1, boardLocation.Col));
                        return legalMoves;
                }
            }
        }
    }
}