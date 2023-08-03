// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] matrix = {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

// // Упорядочиваем элементы каждой строки по убыванию
// SortRowsDescending(matrix);
//     {
// // Выводим результат
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
//     }

//     static void SortRowsDescending(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         // Используем метод Array.Sort() для сортировки элементов текущей строки
//         // по убыванию (в порядке уменьшения)
//         int[] row = new int[arr.GetLength(1)];
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             row[j] = arr[i, j];
//         }
//         Array.Sort(row, (x, y) => y.CompareTo(x));
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = row[j];
//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

int minRow = FindRowWithMinSum(matrix);
{
    // Выводим результат
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minRow);
}

static int FindRowWithMinSum(int[,] arr)
{
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }

    return minRow;
}