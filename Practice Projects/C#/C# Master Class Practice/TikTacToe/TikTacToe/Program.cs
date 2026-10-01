bool gameOver = false;

//create a string array that holds a empty board multiple demantion array
string[,] board =
{
    {"-", "-", "-" },
    { "-", "-", "-" },
    { "-", "-", "-" }
};
//Player 1
Console.WriteLine("Player 1");

//prints the empty board
for(int row = 0; row < board.GetLength(0); row++)
{
    for (int col = 0; col < board.GetLength(1); col++)
    {
        Console.Write(board[row,col] + " ");
    }

    Console.WriteLine();
}

while (!gameOver)
{
    //player1
    Console.WriteLine("Player 1 turn");
    //ask user to enter row and colum
    Console.WriteLine("Enter a row (0-2)");
    int rowInput1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a colum (0-2)");
    int columInput1 = int.Parse(Console.ReadLine());

    //check to make sure user enters the correct number for row and colums

    //print the board and print the X
    if (rowInput1 <= 2 && columInput1 <= 2)
    {
        board[rowInput1, columInput1] = "X";

        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col] + " ");
            }

            Console.WriteLine();
        }

    }
    else
    {
        Console.WriteLine("Error please enter number 0-2");
    }

    gameOver = CheckForWinner(board);
    if (gameOver)
    {
        break;
    }

    //player 2 
    Console.WriteLine("Player 2 turn");

    //prints the empty board
    for (int row = 0; row < board.GetLength(0); row++)
    {
        for (int col = 0; col < board.GetLength(1); col++)
        {
            Console.Write(board[row, col] + " ");
        }

        Console.WriteLine();
    }


    //ask user to enter row and colum
    Console.WriteLine("Enter a row (0-2)");
    int rowInput2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a colum (0-2)");
    int columInput2 = int.Parse(Console.ReadLine());

    //check to make sure user enters the correct number for row and colums

    //print the board and print the O
    if (rowInput2 <= 2 && columInput2 <= 2)
    {
        board[rowInput2, columInput2] = "O";

        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col] + " ");
            }

            Console.WriteLine();
        }

    }
    else
    {
        Console.WriteLine("Error please enter number 0-2");
    }

    gameOver = CheckForWinner(board);

    if (gameOver)
    {
        break;
    }
}

bool CheckForWinner(string[,] board)
{
    //check if x won
    // check rows
    for (int row = 0; row < 3; row++)
    {
        if (board[row, 0] == "X" &&
            board[row, 1] == "X" &&
            board[row, 2] == "X")
        {
            Console.WriteLine("Player 1 wins!");
            return true;
        }
    }

    // check columns
    for (int col = 0; col < 3; col++)
    {
        if (board[0, col] == "X" &&
            board[1, col] == "X" &&
            board[2, col] == "X")
        {
            Console.WriteLine("Player 1 wins!");
            return true;
        }
    }

    //check if o won 
    // check rows
    for (int row = 0; row < 3; row++)
    {
        if (board[row, 0] == "O" &&
            board[row, 1] == "O" &&
            board[row, 2] == "O")
        {
            Console.WriteLine("Player 2 wins!");
            return true;
        }
    }

    // check columns
    for (int col = 0; col < 3; col++)
    {
        if (board[0, col] == "O" &&
            board[1, col] == "O" &&
            board[2, col] == "O")
        {
            Console.WriteLine("Player 2 wins!");
            return true;
        }
    }

    
    return false;
}



