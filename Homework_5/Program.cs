//   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

  
    //     int[] numbers = GenerateRandomArray(2, 100, 999);

    //     Console.WriteLine("Массив чисел:");
    //     PrintArray(numbers);

    //     int countEven = CountEvenNumbers(numbers);
    //     Console.WriteLine("Количество четных чисел: " + countEven);
    

    // static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    // {
    //     Random random = new Random();
    //     int[] array = new int[length];
    //     for (int i = 0; i < length; i++)
    //     {
    //         array[i] = random.Next(minValue, maxValue + 1);
    //     }
    //     return array;
    // }



    // static void PrintArray(int[] array)
    // {
    //     Console.Write("[");
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         Console.Write(array[i]);
    //         if (i < array.Length - 1)
    //         {
    //             Console.Write(", ");
    //         }
    //     }
    //     Console.WriteLine("]");
    // }

    // static int CountEvenNumbers(int[] array)
    // {
    //     int count = 0;
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         if (array[i] % 2 == 0)
    //         {
    //             count++;
    //         }
    //     }
    //     return count;
    // }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




    //     int[] array = new int[4]; // Размер массива можно изменить по вашему усмотрению
    //     Random random = new Random();

    //     // Заполняем массив случайными числами
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         array[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
    //     }

    //     // Находим сумму элементов на нечётных позициях
    //     int result = SumOddPositions(array);

    //     Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
    //     Console.WriteLine("Сумма элементов на нечётных позициях: " + result);
    

    // static int SumOddPositions(int[] arr)
    // {
    //     int sum = 0;

    //     // Обходим массив и складываем элементы на нечётных позициях
    //     for (int i = 1; i < arr.Length; i += 2)
    //     {
    //         sum += arr[i];
    //     }

    //     return sum;
    // }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




        double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };
        
        // Находим максимальное и минимальное значения в массиве
        double max = array[0];
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];

            if (array[i] < min)
                min = array[i];
        }

        // Вычисляем разницу между максимальным и минимальным элементами
        double difference = max - min;

        Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
