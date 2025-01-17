﻿int[] matrixRowCol =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
int rows = matrixRowCol[0];
int cols = matrixRowCol[1];
string[,] matrix = new string[rows, cols];

string input = Console.ReadLine();

Queue<string> queue = new Queue<string>();

foreach (char item in input)
{
    queue.Enqueue(item.ToString());
}


for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {

            matrix[row, col] = queue.Peek();
            queue.Enqueue(queue.Dequeue());

        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = queue.Peek();
            queue.Enqueue(queue.Dequeue());
        }
    }

}

PrintMatrix(matrix);



void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}