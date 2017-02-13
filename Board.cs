using System;


namespace GameOfLife
{

    class Board
    {
        int[,] b;
        public int [,] CreateBoard(int height, int width)
        {
           
            b = new int[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    b[row, column] = 0;
                }
            }
            return b;
        }

        

        public int CheckCellAlive(int row, int col)
        {
            // found algo here https://stackoverflow.com/questions/32657530/wrapping-around-a-grid-with-modulo
            int count = 0;
            int height = b.GetLength(0);
            int width = b.GetLength(1);

            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {

                    count += b[(i + height) % height,(j + width) % width];
                }
            }
            if (count == 3)
            {
                return 1;
            }
            else if (count == 4)
            {
                return b[row, col];
            }
            else
            {
                return 0;
            }
        }
        public void CreateBlinkerBoard()
        {
            b[10, 9] = 1;
            b[10, 10] = 1;
            b[10, 11] = 1;
        }

        public void CreateToadBoard()
        {
            b[10, 9] = 1;
            b[10, 10] = 1;
            b[10, 11] = 1;
            b[11, 8] = 1;
            b[11, 9] = 1;
            b[11, 10] = 1;
        }
        public void CreateBeaconBoard()
        {
            b[9, 9] = 1;
            b[9, 8] = 1;
            b[10, 8] = 1;
            b[11, 11] = 1;
            b[12, 10] = 1;
            b[12, 11] = 1;
            
        }
        public void CreatePulsarBoard()
        {
            b[4, 5] = 1;
            b[4, 6] = 1;
            b[4, 7] = 1;
            b[4, 11] = 1;
            b[4, 12] = 1;
            b[4, 13] = 1;
            b[6, 3] = 1;
            b[6, 8] = 1;
            b[6, 10] = 1;
            b[6, 15] = 1;
            b[7, 3] = 1;
            b[7, 8] = 1;
            b[7, 10] = 1;
            b[7, 15] = 1;
            b[8, 3] = 1;
            b[8, 8] = 1;
            b[8, 10] = 1;
            b[8, 15] = 1;
            b[9, 5] = 1;
            b[9, 6] = 1;
            b[9, 7] = 1;
            b[9, 11] = 1;
            b[9, 12] = 1;
            b[9, 13] = 1;
            b[11, 5] = 1;
            b[11, 6] = 1;
            b[11, 7] = 1;
            b[11, 11] = 1;
            b[11, 12] = 1;
            b[11, 13] = 1;
            b[12, 3] = 1;
            b[12, 8] = 1;
            b[12, 10] = 1;
            b[12, 15] = 1;
            b[13, 3] = 1;
            b[13, 8] = 1;
            b[13, 10] = 1;
            b[13, 15] = 1;
            b[14, 3] = 1;
            b[14, 8] = 1;
            b[14, 10] = 1;
            b[14, 15] = 1;
            b[16, 5] = 1;
            b[16, 6] = 1;
            b[16, 7] = 1;
            b[16, 11] = 1;
            b[16, 12] = 1;
            b[16, 13] = 1;

        }
        public void CreatePentadecathlonBoard()
        {
            b[10, 5] = 1;
            b[10, 6] = 1;
            b[10, 8] = 1;
            b[9, 7] = 1;
            b[10, 9] = 1;
            b[10, 10] = 1;
            b[10, 11] = 1;
            b[10, 13] = 1;
            b[10, 14] = 1;
            b[11, 7] = 1;
            b[9, 12] = 1;
            b[11, 12] = 1;
        }

        public void ChangeState()
        {
            int height = b.GetLength(0);
            int width = b.GetLength(1);
                  
           
            int[,] newB = new int[height,width];
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    newB[row, column] = CheckCellAlive(row, column);
                }
            }
            b = newB;
        }

        public void DisplayBoard(int[,] board)
        {
            int height = b.GetLength(0);
            int width = b.GetLength(1);
                  
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(board[row, column] + "\t");
                    }
                }
            Console.WriteLine(
                "-------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        public int[,] GetBoard()
        {
            return b;
        }
    }
}




