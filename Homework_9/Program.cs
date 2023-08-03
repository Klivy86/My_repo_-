// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Все натуральные числа от " + N + " до 1:");
PrintNaturalNumbers(N);
    

     void PrintNaturalNumbers(int num)
{
    // Базовый случай: если num стало меньше или равно 0, прекращаем рекурсию
    if (num <= 0)
        return;

    // Выводим текущее значение num
    Console.Write(num + " ");

    // Рекурсивно вызываем функцию для следующего числа (num - 1)
    PrintNaturalNumbers(num - 1);
}
