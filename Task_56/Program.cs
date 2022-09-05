// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
            matr[i, j] = Convert.ToInt32(new Random().Next(-10,10));

        }
    }
}

static void SumMatrixLines(int[,] matr) // Сумма элементов чисел строки
{
    int index = 0;
    int min = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        Console.WriteLine("Сумма "+ (i + 1) +" строки = "+ sum);
        if (i == 0) // поиск миннимальной суммы
        {
            min = sum;
        }
        else if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        line = line + matr[index, j] + " ";
    }
    Console.WriteLine("Строка с минимальной суммой элементов - " +"("+ line + ")");
}

Console.Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArraay(matrix);
PrintArray(matrix);
SumMatrixLines(matrix);


