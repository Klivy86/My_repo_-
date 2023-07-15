// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int result = 1;

// for (int i = 0; i < B; i++)
// {
//    result *= A;
// }
//     Console.WriteLine("Результат:" + result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         int sum = 0;
//         int tempNumber = number;

//         while (tempNumber != 0)
//         {
//             int digit = tempNumber % 10;
//             sum += digit;
//             tempNumber /= 10;
//         }

//         Console.WriteLine("Сумма цифр числа: " + sum);

 
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] numbers = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };

        Console.WriteLine("Элементы массива:");
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");