// // Задаем размеры массива m и n

// Console.WriteLine("Введите число - m");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число - n");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// // Метод для заполнения двумерного массива случайными вещественными числами в указанном диапазоне [min, max)
// void RandomFillArray(double[,] array, int m, int n, double min, double max)
// {
//     Random random = new Random();

//     // Проходим по всем строкам и столбцам массива
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             // Генерируем случайное вещественное число от min до max
//             array[i, j] = random.NextDouble() * (max - min) + min;
//         }
//     }
// }

// // Метод для вывода двумерного массива на экран с ограничением до двух цифр после запятой
// void PrintArray(double[,] array, int m, int n)
// {
//     Console.WriteLine("Случайный двумерный массив:");
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             // Форматируем каждый элемент массива с двумя цифрами после запятой
//             Console.Write($"{array[i, j]:F2} \t");
//         }

//         Console.WriteLine();
//     }
// }

// // Заполняем двумерный массив случайными вещественными числами в диапазоне [-10, 10)
// RandomFillArray(array, m, n, -10, 10);

// // Выводим массив на экран с ограничением до двух цифр после запятой
// PrintArray(array, m, n);
// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = {
//                 { 1, 2, 7, 2 },
//                 { 5, 9, 2, 3 },
//                 { 8, 4, 2, 4 }
//             };

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int value = GetArrayElement(array, row, col);
// {

//     if (value != -1)
//     {
//         Console.WriteLine($"Значение элемента: {value}");
//     }
//     else
//     {
//         Console.WriteLine("Такого элемента не существует.");
//     }
// }

// int GetArrayElement(int[,] array, int row, int col)
// {
//     int numRows = array.GetLength(0);
//     int numCols = array.GetLength(1);

//     if (row >= 0 && row < numRows && col >= 0 && col < numCols)
//     {
//         return array[row, col];
//     }

//     else
//     {


//         // Если позиция элемента выходит за пределы массива, возвращаем -1
//         return -1;
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.




int[,] array = {
                { 1, 4, 7, 2 },
                { 5, 9, 2, 3 },
                { 8, 4, 2, 4 }
            };

int rows = array.GetLength(0); // Количество строк
int cols = array.GetLength(1); // Количество столбцов

double[] averages = new double[cols]; // Массив для хранения средних значений

// Находим среднее значение для каждого столбца
for (int j = 0; j < cols; j++)
{
    averages[j] = CalculateColumnAverage(array, rows, j);
}

// Выводим средние значения для каждого столбца
PrintAverages(averages, cols);


double CalculateColumnAverage(int[,] array, int rows, int colIndex)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, colIndex]; // Суммируем элементы в столбце
    }
    return (double)sum / rows; // Вычисляем среднее арифметическое для столбца
}

void PrintAverages(double[] averages, int cols)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"Столбец {j + 1}: {averages[j]:F1}");
    }
}
