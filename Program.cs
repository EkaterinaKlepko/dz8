// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }

// void Sort(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Sort(array);
// Console.WriteLine();
// PrintArray(array);


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

int[] Sum(int[,] array)
{
    int sum = 0;
    int[] array1 = new int[array.GetLength(0) + 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i, j];
            sum = temp;

        }
        Console.Write($"{sum} \t");
        array1[i] = sum;
    }
    return array1;
}

void PrintResult(int[] array)
{
    int min = array[0];
    int number = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            number = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {number}");
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintResult(Sum(array));