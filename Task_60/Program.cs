// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;
void PrintArray(int[,,] matr) // Метод распечатки массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // распечатать массив
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i,j,k] + " ("+i + "," +j+ "," + k+ ") "); // Вывод массива с индексом
               
            }
           Console.WriteLine();  
        }
        //Console.WriteLine();
    }
}
void FillArraay(int[,,] matr) // Заполение массива случайными числамии
{
  int[] temp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100); // Заполнение неповторяющимися числами
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matr.GetLength(0); x++) 
  {
    for (int y = 0; y < matr.GetLength(1); y++)
    {
      for (int z = 0; z < matr.GetLength(2); z++)
      {
        matr[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.Clear();
Console.Write("Ввседите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввседите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввседите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[x, y,z];
FillArraay(matrix);
PrintArray(matrix);