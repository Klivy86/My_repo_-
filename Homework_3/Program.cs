// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.WriteLine("Введите пятизначное число:");
//         int number = Convert.ToInt32(Console.ReadLine());


//         int fifthDigit = number % 10;
//         number /= 10;

//         int fourthDigit = number % 10;
//         number /= 10;

//         int thirdDigit = number % 10;
//         number /= 10;

//         int secondDigit = number % 10;
//         number /= 10;

//         int firstDigit = number;

//         bool isPalindrome = (firstDigit == fifthDigit) && (secondDigit == fourthDigit);

//         if (isPalindrome)
//         {
//             Console.WriteLine("Да, число является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Нет, число не является палиндромом.");
//         }
    
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки A (x, y, z):");
//         double x1 = Convert.ToDouble(Console.ReadLine());
//         double y1 = Convert.ToDouble(Console.ReadLine());
//         double z1 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Введите координаты точки B (x, y, z):");
//         double x2 = Convert.ToDouble(Console.ReadLine());
//         double y2 = Convert.ToDouble(Console.ReadLine());
//         double z2 = Convert.ToDouble(Console.ReadLine());

//         double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1)));

//  Console.WriteLine("Расстояние между точкой A и точкой B: " + distance.ToString("F2"));

//   Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.Write(cube + " ");
        }
