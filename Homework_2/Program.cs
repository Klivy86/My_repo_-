// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



// -Задача 10-



// Console.WriteLine("Введите трехзначное число:");
//         string input = Console.ReadLine();

//         if (input.Length == 3)
//         {
//             char secondDigit = input[1];
//             Console.WriteLine($"Вторая цифра числа: {secondDigit}");
//         }
//         else
//         {
//             Console.WriteLine("Ошибка! Введите трехзначное число.");
//         }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите трехзначное число:");
//         string input = Console.ReadLine();

//         if (input.Length > 2 )
//         {
//             char thirdDigit = input[2];
//             Console.WriteLine($"Третья цифра заданного числа: {thirdDigit}");
//         }
//         else
//         {
//             Console.WriteLine("Ошибка! третьей цифры нет .");
//         }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
