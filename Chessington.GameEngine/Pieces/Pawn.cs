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
            legalMoves = GetLegalMoves(boardLocation, legalMoves, board);
            return legalMoves;
        }

        private List<Square> GetLegalMoves(Square boardLocation, List<Square> legalMoves, Board board)
        {
            if (Player == Player.Black)
            {
                switch (boardLocation.Row)
                {
                    case 1: //moves up one or two squares
                        var oneSqMove = new Square(boardLocation.Row + 1, boardLocation.Col);
                        var twoSqMove = new Square(boardLocation.Row + 2, boardLocation.Col);
                        
                        if (Moves.SquareIsEmpty(oneSqMove, board))   //check if empty
                        {
                            legalMoves.Add(oneSqMove);
                        }
                        if (Moves.SquareIsEmpty(twoSqMove, board) && Moves.SquareIsEmpty(oneSqMove, board))
                        {
                            legalMoves.Add(twoSqMove);
                        }
                        return legalMoves;
                    default:                  // if not 1, moves up one square
                        var onlySqMove = new Square(boardLocation.Row + 1, boardLocation.Col);
                       
                        if (Moves.SquareIsEmpty(onlySqMove, board))
                        {
                            legalMoves.Add(onlySqMove);
                        }
                        return legalMoves;
                }
            }
            else
            {
                switch (boardLocation.Row)  // white player
                {
                    case 6: //moves down one or two squares
                        var oneSqMove = new Square(boardLocation.Row - 1, boardLocation.Col);
                        var twoSqMove = new Square(boardLocation.Row - 2, boardLocation.Col);
                        
                        if (Moves.SquareIsEmpty(oneSqMove, board))   // check if empty
                        {
                            legalMoves.Add(oneSqMove);
                        }
                        if (Moves.SquareIsEmpty(twoSqMove, board)&& Moves.SquareIsEmpty(oneSqMove, board))
                        {
                            legalMoves.Add(twoSqMove);
                        }
                        return legalMoves;
                    default: // if not 6 moves down one square 
                        var onlySqMove = new Square(boardLocation.Row - 1, boardLocation.Col);

                        if (Moves.SquareIsEmpty(onlySqMove, board))
                        {
                            legalMoves.Add(onlySqMove);
                        }                        
                        return legalMoves;
                }
            }
        }
    }
}