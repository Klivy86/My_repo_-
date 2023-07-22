// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Пользователю предлагается ввести количество чисел M:
// Console.WriteLine("Введите количество чисел M:");
//             int M = Convert.ToInt32(Console.ReadLine());
// // Создаем переменную countPositive и инициализируем ее нулем. Она будет использоваться для подсчета количества чисел, больших нуля:
//             int countPositive = 0;
// // Запускаем цикл for для ввода чисел и их подсчета:
//             for (int i = 1; i <= M; i++)
//             {
//                 Console.Write($"Введите число {i}: ");
//                 int number = Convert.ToInt32(Console.ReadLine());

//                 if (number > 0)
//                 {
//                     countPositive++;
//                 }
//             }
// // Выводим результат на экран:
//             Console.WriteLine($"Количество чисел больше 0: {countPositive}");
        

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

            Console.WriteLine("Введите значение k1:");
            double k1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b1:");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение k2:");
            double k2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b2:");
            double b2 = double.Parse(Console.ReadLine());

            // Проверяем, пересекаются ли прямые, сравнивая значения k1 и k2. Если k1 и k2 равны, прямые параллельны и не имеют точек пересечения. В таком случае выводим соответствующее сообщение.
            if (k1 == k2)
            {
                Console.WriteLine("Прямые параллельны и не пересекаются.");
            }
            else
            {
                // Если прямые не параллельны, вычисляем x-координату точки пересечения как (b2 - b1) / (k1 - k2).
                double xIntersection = (b2 - b1) / (k1 - k2);

                // Затем, используя найденную x-координату, вычисляем y-координату точки пересечения как k1 * xIntersection + b1.
                double yIntersection = k1 * xIntersection + b1;

                // Выводим найденные координаты точки пересечения на экран.
                Console.WriteLine($"Точка пересечения: ({xIntersection}, {yIntersection})");
            }