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

// int[,] matrix = {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 },
//             { 5, 2, 6, 7 }
//         };

// int minRow = FindRowWithMinSum(matrix);
// {
//     // Выводим результат
//     Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minRow);
// }

// static int FindRowWithMinSum(int[,] arr)
// {
//     int minSum = int.MaxValue;
//     int minRow = -1;

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i, j];
//         }

//         if (sum < minSum)
//         {
//             minSum = sum;
//             minRow = i;
//         }
//     }

//     return minRow;
// }
// Задача 58:  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// int[,] matrix1 = {
//             { 2, 4 },
//             { 3, 2 }
//         };

// int[,] matrix2 = {
//             { 3, 4 },
//             { 3, 3 }
//         };

// int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);

// Выводим результат
// Console.WriteLine("Произведение матриц:");
// PrintMatrix(productMatrix);


//     static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
// {
//     int rows1 = matrix1.GetLength(0);
//     int cols1 = matrix1.GetLength(1);
//     int rows2 = matrix2.GetLength(0);
//     int cols2 = matrix2.GetLength(1);

//     if (cols1 != rows2)
//         throw new ArgumentException("Несовместимые матрицы для умножения.");

//     int[,] result = new int[rows1, cols2];

//     for (int i = 0; i < rows1; i++)
//     {
//         for (int j = 0; j < cols2; j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < cols1; k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }
//             result[i, j] = sum;
//         }
//     }

//     return result;
// }
// void PrintMatrix(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4; // размерность массива
int[,] spiralArray = new int[n, n];

FillSpiralArray(spiralArray);
{

    // Выводим заполненный спиральный массив
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(spiralArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillSpiralArray(int[,] arr)
{
    int n = arr.GetLength(0);
    int currentNumber = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (currentNumber <= n * n)
    {
        // Вправо
        for (int i = colStart; i <= colEnd; i++)
        {
            arr[rowStart, i] = currentNumber++;
        }
        rowStart++;

        // Вниз
        for (int i = rowStart; i <= rowEnd; i++)
        {
            arr[i, colEnd] = currentNumber++;
        }
        colEnd--;

        // Влево
        for (int i = colEnd; i >= colStart; i--)
        {
            arr[rowEnd, i] = currentNumber++;
        }
        rowEnd--;

        // Вверх
        for (int i = rowEnd; i >= rowStart; i--)
        {
            arr[i, colStart] = currentNumber++;
        }
        colStart++;
    }
}