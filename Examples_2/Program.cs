// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число a: ");
//             int num_A = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Введите число b: ");
//             int num_B = Convert.ToInt32(Console.ReadLine());

//             if (num_A > num_B)
//             {
//                 Console.WriteLine("Max чиcло a = " +  CancellationTokennum_A);
//             }
//             if (num_B > num_A)
//             {
//                 Console.WriteLine("Max чиcло b = ");
//             }
       

//  Console.WriteLine("Введите 3 числа: ");



//  int num_A = Convert.ToInt32(Console.ReadLine());
//  int num_B = Convert.ToInt32(Console.ReadLine());
//  int num_C = Convert.ToInt32(Console.ReadLine());

//  int max = num_A;

//  if (num_B > max)

//  {
//     max = num_B;
//  }

//  if (num_C > max)

//  {
//     max = num_C;
//  }

 
//             Console.WriteLine("Максимальное число  = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            // Console.WriteLine("Введите число:");
            // int num = Convert.ToInt32(Console.ReadLine());

            // if (num % 2 == 1)
            // {
            //     Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            // }
            // else
            // {
            //     Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            // }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8       
int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }     