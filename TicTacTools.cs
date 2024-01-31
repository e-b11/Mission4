using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class TicTacTools
    {
        public string[] getBoard(string[] board)
        {
            return board;
        }

        public string printBoard(string[] board)
        {
            string boardOutput = "";

            boardOutput += ($"{board[0]}|{board[1]}|{board[2]}\n------\n{board[3]}|{board[4]}|{board[5]}\n------\n{board[6]}|{board[7]}|{board[8]}\n");

            return boardOutput;
        }

        public string gameResult(string[] board, string turn, int turns)
        {
            bool winner = false;
            string message = "";
            string player = "";

        /*Winning combinations: 
         * (123), (456), (789), (147), (258), (369)
         * (159), (357)
         * Subtract 1 from each number to work w/ array
         */
            if (board[0] == turn & board[1] == turn & board[2] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[3] == turn & board[4] == turn & board[5] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[6] == turn & board[7] == turn & board[8] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[0] == turn & board[3] == turn & board[6] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[1] == turn & board[4] == turn & board[7] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[2] == turn & board[5] == turn & board[8] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[0] == turn & board[4] == turn & board[8] == turn)
            {
                winner = true;
                player = turn;
            }
            else if (board[2] == turn & board[4] == turn & board[6] == turn)
            {
                winner = true;
                player = turn;
            }

            if (winner == true)
            {
                message += turn + " has won the game!";
            }
            else if (turns >= 9) {
                message += "Cat's game. No winner.";
            }
            else {
                message += "No winner yet. Next player's turn";
            }

            return message;
        }
    }
}
