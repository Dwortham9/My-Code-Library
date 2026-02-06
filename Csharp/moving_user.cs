using System;

class moving_user
{
    enum DIRECTION { UP, DOWN, LEFT, RIGHT };

    const int rows = 10;
    const int cols = 10;
    const int OBSTACLE_INT = 1;
    const char OBSTACLE_CHAR = '#';

    const int EMPTY_SPACE_INT = 0;
    const char EMPTY_SPACE_CHAR = ' ';


    static int[,] array = new int[rows, cols];

    static int player_row = 0;
    static int player_col = 0;

    static void display()
    {
        Console.WriteLine();

        for (int r = 0; r < array.GetLength(0); ++r)
        {
            for (int c = 0; c < array.GetLength(1); ++c)
            {

                if (r == player_row && c == player_col)
                {
                    Console.Write("O");
                }
                else
                {
                    int value = array[r, c];
                    switch (value)
                    {
                        case EMPTY_SPACE_INT:
                            Console.Write(EMPTY_SPACE_CHAR);
                            break;
                        case OBSTACLE_INT:
                            Console.Write(OBSTACLE_CHAR);
                            break;
                        default:
                            Console.Write(value);
                            break;
                    }
                }

            }
            Console.WriteLine();
        }
    }

    static void set_borders()
    {

        int lastcolumn = array.GetLength(1) - 1;
        int lastrow = array.GetLength(0) - 1;

        for (int row = 0; row < array.GetLength(0); ++row)
        {
            array[row, 0] = 1;
            array[row, lastcolumn] = 1;
        }

        for (int col = 0; col < array.GetLength(1); ++col)
        {
            array[0, col] = 1;
            array[lastrow, col] = 1;
        }
    }

    static bool move(DIRECTION dir)
    {
        int new_player_row = player_row;
        int new_player_col = player_col;
        switch (dir)
        {
            case DIRECTION.LEFT:
                new_player_col--;
                break;
            case DIRECTION.RIGHT:
                new_player_col++;
                break;
            case DIRECTION.UP:
                new_player_row--;
                break;
            case DIRECTION.DOWN:
                new_player_row++;
                break;
            default:
                Console.WriteLine("Error - " +
                    "Unimplemented direction");
                break;
        }

        if (new_player_col < 0 || new_player_col >=
            array.GetLength(1))
        {
            return false;
        }

        if (new_player_row < 0 || new_player_row >=
            array.GetLength(0))
        {
            return false;
        }

        int value = array[new_player_row, new_player_col];
        if (value == OBSTACLE_INT)
        {
            return false;
        }

        array[player_row, player_col] = OBSTACLE_INT;

        player_row = new_player_row;
        player_col = new_player_col;

        return true;
    }

    static void Main(string[] args)
    {

        player_row = 4;
        player_col = 5;

        set_borders();
        display();
        bool c = true;
        while (c) 
        {
            Console.WriteLine("Type left, right, up, and down to control the player or type QUIT to stop.");
            string action = Console.ReadLine();
            if (action == "left")
            {
                move(DIRECTION.LEFT);
                display();
            }
            if (action == "right")
            {
                move(DIRECTION.RIGHT);
                display();
            }
            if (action == "up")
            {
                move(DIRECTION.UP);
                display();
            }
            if (action == "down")
            {
                move(DIRECTION.DOWN);
                display();
            }
            if (action == "QUIT")
            {
                c = false;
                break;
            }
        }
        
        Console.WriteLine("Done");

    }
}
