// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Все натуральные числа от " + N + " до 1:");
// PrintNaturalNumbers(N);


// void PrintNaturalNumbers(int num)
// {
//     // Базовый случай: если num стало меньше или равно 0, прекращаем рекурсию
//     if (num <= 0)
//         return;

//     // Выводим текущее значение num
//     Console.Write(num + " ");

//     // Рекурсивно вызываем функцию для следующего числа (num - 1)
//     PrintNaturalNumbers(num - 1);
// }
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int sum = CalculateSumOfNaturalNumbers(M, N);

Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна: " + sum);


static int CalculateSumOfNaturalNumbers(int start, int end)
{
    // Проверяем, чтобы start был не больше end
    if (start > end)
        throw new ArgumentException("Некорректный промежуток: M должно быть не больше N.");

    // Базовый случай: если start равен end, возвращаем его же
    if (start == end)
        return start;

    // Рекурсивно вызываем функцию для следующего числа (start + 1) и суммируем его с текущим значением start
    return start + CalculateSumOfNaturalNumbers(start + 1, end);
}