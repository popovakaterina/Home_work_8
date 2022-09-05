// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
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
void FillArraay(int[,] matr) // Заполение массива случайными числамии
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToInt32(new Random().Next(0,10));

        }
    }
}
Console.Clear();
//Console.WriteLine("Количество строк первой матрицы должно равняться количеству столбцов второй матрицы\n");
Console.Write("Введите количество строк первого массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
FillArraay(matrix1);
Console.WriteLine("\nПервый массив:");
PrintArray(matrix1);

Console.Write("Введите количество строк второго массива (p): ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива (b): ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[p, b];
FillArraay(matrix2);
Console.WriteLine("\nВторой массив:");
PrintArray(matrix2);
/* Для нахождения произведения матриц необходимо умножить строки первой матрицы на столбцы второй. 
Количество строк первой матрицы должно равняться количеству столбцов второй матрицы*/

void Proisv (int [,] matrix1, int [,] matrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int proisv = 0;
            for (int l = 0; l < matrix1.GetLength(1); l++) // цикл по столбцу первой матрицы, тк идет умножение столбца на строку
            {
                proisv = proisv + (matrix1[i,l]*matrix2[l,j]);
            }
            result[i,j] = proisv;
        }
    }
}
int[,] result = new int[m,b];

Proisv(matrix1, matrix2, result);
Console.WriteLine("\nПроизведение первой и второй матриц:");
PrintArray(result);