//Задать двумерный массив из целых чисел, найти среднее арифметическое элементов в каждом столбце.

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

void Average(int[,] matrix)

{
    int sum = 0;
    int j = 0;
    
       
         while (j < matrix.GetLength(1))
        {
           for (int i = 0; i < matrix.GetLength(0); i++)
           {
            sum  +=  matrix[i,j];
           }
           double result = Convert.ToDouble(sum)/Convert.ToDouble(rows);
            Console.WriteLine("{0:0.0}", result);
            j++;
            sum = 0;
            
        }
}
Average(result);

