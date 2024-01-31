using Mission4;

TicTacTools ttt = new TicTacTools();

string[] board = ["X", "X", "X", "O", "O", "O", "7", "8", "9"];

Console.WriteLine(ttt.printBoard(board));

Console.WriteLine(ttt.gameResult(board, "X", 6));
