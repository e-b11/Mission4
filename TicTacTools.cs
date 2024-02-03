
//Eliza Sorensen, Emma Bastian, Josh Michaelson, Javier De los Reyes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class TicTacTools
    {
     
        //Takes board array and then returns it to look like tic-tac-toe board
        public string printBoard(string[] board)
        {
            string boardOutput = "";

            boardOutput += ($"\n{board[0]}|{board[1]}|{board[2]}\n------\n{board[3]}|{board[4]}|{board[5]}\n------\n{board[6]}|{board[7]}|{board[8]}\n");

            return boardOutput;
        }

        //Takes in board array, whose turn it is, and number of turns there have been, looks to see if there has been a winning
        //combination, and who won. Returns a message depending on if there was a winner/who it was, if it was a tie, or if there isn't 
        // a winner and it's the next players turn
        public bool gameResult(string[] board, string turn, int turns)
        {
            bool winner = false;
            bool gameOver = false;
            
        /* Winning combinations: 
         * (123), (456), (789), (147), (258), (369)
         * (159), (357)
         * Subtract 1 from each number to work w/ array
         */
            if (board[0] == turn && board[1] == turn & board[2] == turn)
            {
                winner = true;
                            }
            else if (board[3] == turn & board[4] == turn & board[5] == turn)
            {
                winner = true;
                            }
            else if (board[6] == turn & board[7] == turn & board[8] == turn)
            {
                winner = true;
                         }
            else if (board[0] == turn & board[3] == turn & board[6] == turn)
            {
                winner = true;
            }
            else if (board[1] == turn & board[4] == turn & board[7] == turn)
            {
                winner = true;
            }
            else if (board[2] == turn & board[5] == turn & board[8] == turn)
            {
                winner = true;
            }
            else if (board[0] == turn & board[4] == turn & board[8] == turn)
            {
                winner = true;
            }
            else if (board[2] == turn & board[4] == turn & board[6] == turn)
            {
                winner = true;
            }

            if (winner == true)
            {
                Console.WriteLine(turn + " has won the game!");
                gameOver = true;
            }
            else if (turns >= 9) {
                Console.WriteLine("Cat's game. No winner.");
                gameOver = true;
            }
     
            return gameOver;
        }
    }
}
