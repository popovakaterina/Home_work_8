// Напишите программу, которая заполнит спирально массив 4 на 4.
void PrintArray(int[,] matr) // Метод распечатки массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // распечатать массив
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            Console.Write(matr[i, j] + " "); // вывод массива
            //Console.Write(";");
        }

        Console.WriteLine();
    }
}
void FillArraay(int[,] matr) // Заполение спирального массива числамии
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matr.GetLength(0) * matr.GetLength(1))
{
  matr[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
  {
    j++;
  }
  else if (i < j && i + j >= matr.GetLength(0) - 1)
  {
     i++;
  }
  else if (i >= j && i + j > matr.GetLength(1) - 1)
  {
    j--;
  }
    
  else
  {
     i--;
  }
   
}
}

Console.Clear();
int n = 4;
int[,] matrix = new int[n, n];
FillArraay(matrix);
Console.WriteLine("\nМассив:");
PrintArray(matrix);
