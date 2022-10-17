using System;
//Write a program that reads a positive integer number N (N<20]
//from console and outputs on console the numbers 1... arranged in spiral 
//n = 4 
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7



internal class EntryPoint
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Input number of rows and columns you want : ");
        Console.ResetColor();

        int n = int.Parse(Console.ReadLine());
        int row = 0;
        int col = 0;

        string direction = "right";



        int[,] spiralMatrix = new int[n, n];

        for (int i = 1; i <= spiralMatrix.Length; i++) // it will give us full length ie 4*4
        {
            if (direction == "right" && ( col == n - 1 || spiralMatrix[row , col + 1] != 0))
            {
                direction = "down";
            }
            else if (direction == "down" && (row == n - 1 || spiralMatrix[row + 1, col] != 0))
            {
                direction = "left";
            }
            else if (direction == "left" && (col == 0 || spiralMatrix[row , col -1] != 0))
            {
                direction = "up";
            }
            else if(direction == "up" && (row == 0 || spiralMatrix[row -1 ,col  ] != 0))
            {
                direction = "right";
            }




            spiralMatrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if(direction == "up")
            {
                row--;
            }

        }

        for (int i = 0; i < spiralMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < spiralMatrix.GetLength(1); j++)
            {
                Console.Write("{0,  3}", spiralMatrix[i,j]);
            }
            Console.WriteLine();
        }

     
    }
}

