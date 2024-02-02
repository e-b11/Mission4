//Methods: printBoard(board) take 1 parameter of board array
//          getBoard(board) takes 1 parameter of board array and returns it         
//          gameResult(string[] board, string turn, int turns) take in board array, whose turn it is ("X" or "O"), and how many turns there have been

using Mission4;

//Create instance of suppporting class
TicTacTools ttt = new TicTacTools();

//Possible board array, so player can choose a position. They'll know they can't use it once an X or O is in there
string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

//Game Logic

Console.WriteLine("Welcome to tic tac toe!");
Console.WriteLine("For each players turn, enter the number on the board you would like to play.");
Console.WriteLine("Here is the board, X's go first!");

// initialize game stuffs
int numTurns = 0;
bool gameOver = false;
string turn = "X";

while (gameOver == false)
{
    ttt.printBoard();
    // Get player input
    string move = Console.ReadLine();
    gameOver = ttt.gameResult(board, turn, numTurns);

    // change turns
    if (turn == "X")
    {
        turn = "O";
    }
    else
    {
        turn = "X";
    }
}






Console.WriteLine(ttt.printBoard(board));

Console.WriteLine(ttt.gameResult(board, "X", 6));
