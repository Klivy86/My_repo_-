// Задаем размеры массива m и n

Console.WriteLine("Введите число - m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

// Метод для заполнения двумерного массива случайными вещественными числами в указанном диапазоне [min, max)
void RandomFillArray(double[,] array, int m, int n, double min, double max)
{
    Random random = new Random();

    // Проходим по всем строкам и столбцам массива
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Генерируем случайное вещественное число от min до max
            array[i, j] = random.NextDouble() * (max - min) + min;
        }
    }
}

// Метод для вывода двумерного массива на экран с ограничением до двух цифр после запятой
void PrintArray(double[,] array, int m, int n)
{
    Console.WriteLine("Случайный двумерный массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Форматируем каждый элемент массива с двумя цифрами после запятой
            Console.Write($"{array[i, j]:F2} \t");
        }

        Console.WriteLine();
    }
}

// Заполняем двумерный массив случайными вещественными числами в диапазоне [-10, 10)
RandomFillArray(array, m, n, -10, 10);

// Выводим массив на экран с ограничением до двух цифр после запятой
PrintArray(array, m, n);