
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
        int number = Convert.ToInt32(Console.ReadLine());


        int fifthDigit = number % 10;
        number /= 10;

        int fourthDigit = number % 10;
        number /= 10;

        int thirdDigit = number % 10;
        number /= 10;

        int secondDigit = number % 10;
        number /= 10;

        int firstDigit = number;

        bool isPalindrome = (firstDigit == fifthDigit) && (secondDigit == fourthDigit);

        if (isPalindrome)
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    
