// Создать двумерный массив размером m*n, заполенный случайными вещественными числами
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


double [,] arrayrandom (int m, int n)
{

   double[,] matrix = new double [m,n];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i,j] = new Random().Next(-100, 100)*0.1; 
      }
   }
   return matrix;
}
double[,] result = arrayrandom(rows, columns);

void PrintArray (double [,] inputMatrix)
{

     for (int i = 0; i < inputMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < inputMatrix.GetLength(1); j++)
      {
         Console.Write(inputMatrix[i,j] + "\t");
      }
      Console.WriteLine();
   }
   
}

    PrintArray(result);
    
    
