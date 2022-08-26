// Вход позиции элемента в двумерном массиве, и возврат значения этого элемента или, что такого элемента нет.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arrayrandom(int m, int n)
{

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(100);
        }
    }
    return matrix;
}
int[,] result = arrayrandom(rows, columns);

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
PrintArray(result);

void Find(int[,] matrix)

{
    Console.WriteLine("Введите позицию строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите позицию столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row > rows || column > columns) Console.WriteLine("Такого элемента нет");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == column) Console.WriteLine($"Значение элемента: {matrix[row, column]}");
        }
    }
}
Find(result);
