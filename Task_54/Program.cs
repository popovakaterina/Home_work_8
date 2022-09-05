// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 10));

        }
    }
}

void FromMaxToMin (int[,] array) // Метод сотировки от большего к меньшему
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int newarray = array[i,k+1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = newarray;
                }
                
            }
        }
    }
}
Console.Write("Ввседите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввседите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArraay(matrix);
Console.WriteLine("Первоначальный массив:");
PrintArray(matrix);
Console.WriteLine("Отсортированный массив:");
FromMaxToMin(matrix);
PrintArray(matrix);