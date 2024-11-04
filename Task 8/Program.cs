using System;

class ColumnProductCalculator
{
    public int CalculateColumnProduct(int[,] matrix, int columnIndex)
    {
        int product = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            product *= matrix[i, columnIndex];
        }

        return product;
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

        int targetColumn = 1; // Замініть на бажаний стовпець
        ColumnProductCalculator columnProductCalculator = new ColumnProductCalculator();
        int columnProduct = columnProductCalculator.CalculateColumnProduct(matrix, targetColumn);
        Console.WriteLine("Product of elements in column {0}: {1}", targetColumn, columnProduct);
    }
}
