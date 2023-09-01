namespace HelloWorld
{
    class Program
    {
        static char[,] board = 
        {
            {' ', ' ', 'N', 'N', ' '},
            {'N', 'N', ' ', 'N', ' '},
            {' ', 'N', 'N', ' ', 'N'},
            {'N', ' ', 'N', ' ', 'N'},
            {' ', 'N', ' ', 'N', 'N'},
        };
        static int row = 5;
        static int col = 5;

        static void DisplayBoard ()
        {
            int i = 0;
            int j;

            while (i < row)
            {
                j = 0;
                while (j < col)
                {
                    Console.Write(board[i, j]);
                    j++;
                }
                Console.Write('\n');
                i++;
            }
            Console.Write('\n');
        }

        static bool PassAlgo(int x, int y)
        {
            // put current position
            board[x, y] = 'T';
            DisplayBoard();

            // if reach last row, return
            if (x == row - 1)
                return true;

            // check left-bot
            if (y - 1 >= 0 && board[x + 1, y - 1] == ' ')
            {
                board[x, y] = 'A';
                if (PassAlgo(x + 1, y - 1))
                    return true;
                board[x, y] = 'T';
            }
            // check bot
            if (board[x + 1, y] == ' ')
            {
                board[x, y] = 'A';
                if (PassAlgo(x + 1, y))
                    return true;
                board[x, y] = 'T';
            }
            // check right-bot
            if (y + 1 < col && board[x + 1, y + 1] == ' ')
            {
                board[x, y] = 'A';
                if (PassAlgo(x + 1, y + 1))
                    return true;
                board[x, y] = 'T';
            }
            // check left
            if (y - 1 >= 0 && board[x, y - 1] == ' ')
            {
                board[x, y] = 'A';
                if (PassAlgo(x, y - 1))
                    return true;
                board[x, y] = 'T';
            }
            // check right
            if (y + 1 < col && board[x, y + 1] == ' ')
            {
                board[x, y] = 'A';
                if (PassAlgo(x, y + 1))
                    return true;
                board[x, y] = 'T';
            }

            // backtrack if cannot go further
            board[x, y] = ' ';

            return false;
        }

        static void Main()
        {
            Console.WriteLine("Before:");
            DisplayBoard();

            bool canPass = false;
            int j = 0;
            while (j < col)
            {
                if (board[0, j] == ' ')
                    canPass = PassAlgo(0, j);
                if (canPass)
                    break;
                j++;
            }

            if (canPass)
            {
                Console.WriteLine("After:");
                DisplayBoard();
            }
            else
                Console.WriteLine("No solution");
        }
    }
}