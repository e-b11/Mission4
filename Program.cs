
//Eliza Sorensen, Emma Bastian, Josh Michaelson, Javier De los Reyes
//Choose whether to be X or O, and then play a game of tic tac toe. Once the game is finished, choose whether to play again or not.

using Mission4;
using System;


class Program {
    static void Main(string[] args) {
        //Create instance of suppporting class
        TicTacTools ttt = new TicTacTools();
        
        // initialize variables
        int numTurns = 0;
        bool gameOver = false;
        string turn = "";
        bool validChoice = true;
        string moveStr = "";

        //Board array, so player can choose a position. They'll know they can't use it once an X or O is in there
        string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        //Game Logic

        Console.WriteLine("Welcome to tic tac toe!");
        Console.WriteLine("For each player's turn, enter the number on the board you would like to play.");
        Console.WriteLine("Player 1: Would you like to be X or O?");
        
        //Get player decision. If it is not an X or O (not case sensitive), they will be prompted to try again
        do
        {
            turn = Console.ReadLine();
            if (turn.ToUpper() != "X" && turn.ToUpper() != "O")
            {
                Console.WriteLine("Please enter an X or an O.");
            }
            else
            {
                turn = turn.ToUpper();
            }

        } while (turn.ToUpper() != "X" && turn.ToUpper() != "O");
        
        Console.WriteLine($"Here is the board, Player 1 ({turn}) goes first!");


        //create a list to keep track of used slots on the board
        List<int> usedMoves = new List<int>();

        //do while game is in play
        while (gameOver == false)
        {

            Console.WriteLine(ttt.printBoard(board));
            
            Console.WriteLine(turn + "'s turn!");
                        
            // Get player input. If it is not a valid number position, prompt user to try again
            do
            {
                moveStr = Console.ReadLine();

                //look to see if input is/could be an integer
                if (!int.TryParse(moveStr, out int move))
                {
                    Console.WriteLine("Please Enter a valid number input");
                    validChoice = false;
                }
                else if (int.Parse(moveStr) < 1 | int.Parse(moveStr) > 9)
                {
                    Console.WriteLine("Please Enter a valid number input");
                    validChoice = false;
                }
                else
                {
                    validChoice = true;
                }
            } while (!validChoice);




            //make string input an integer
            int moveInt = int.Parse(moveStr) - 1;

            //look to see if position number is in the array of used spots, if not allow the user to play it and add it to array of used slots,
            //or make them enter a new number if the slot has already been used

            if (usedMoves.Contains(moveInt))
            {
                Console.WriteLine("Please Pick a Slot that has not been used");

            }
            else
            {
                usedMoves.Add(moveInt);
                board[moveInt] = turn;
                numTurns++;
                //Calls gameResult method to see if there is a winner yet
                gameOver = ttt.gameResult(board, turn, numTurns);
                turn = (turn == "X") ? "O" : "X";


            }
        }

        Console.WriteLine(ttt.printBoard(board));

        //see if the user wants to play again and based off the response either rerun game or thank them for playing
        //variables/arguments are reset when main method is called again
        Console.WriteLine("Do you want to play again? (y/n)");
        string playAgain = Console.ReadLine();
        
        //If player does not type a y or Y, program will end
        if (playAgain.ToLower() == "y")
        {            
           //Run program again
           Main(args);
        }
        else
        {
            Console.WriteLine("\nThanks for playing!");                                          
        }
       
    } 
}

