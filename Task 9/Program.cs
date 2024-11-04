using System;

class MatrixRotator
{
    public int[,] RotateMatrixCounterClockwise(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[,] rotatedMatrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rotatedMatrix[i, j] = matrix[j, n - 1 - i];
            }
        }

        return rotatedMatrix;
    }
}

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        MatrixRotator matrixRotator = new MatrixRotator();
        int[,] rotatedMatrix = matrixRotator.RotateMatrixCounterClockwise(matrix);

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("\nRotated Matrix (90 degrees counter-clockwise):");
        PrintMatrix(rotatedMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}