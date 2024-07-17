//               Задача 1:
//Задайте значения M и N. Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.
//               РЕШЕНИЕ

// using System;

// class Program
// {
//     static void PrintNaturalNumbers(int start, int end)
//     {
//         if (start <= end)
//         {
//             Console.WriteLine(start); // Выводим текущее число
//             PrintNaturalNumbers(start + 1, end); // Рекурсивный вызов для следующего числа
//         }
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение M: "); // Запрашиваем у пользователя значение M
//         int M = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в целое число

//         Console.Write("Введите значение N: "); // Запрашиваем у пользователя значение N
//         int N = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в целое число

//         Console.WriteLine("Натуральные числа в промежутке от {0} до {1}:", M, N); // Выводим сообщение с диапазоном чисел
//         PrintNaturalNumbers(M, N); // Вызываем метод для вывода натуральных чисел

//         Console.ReadLine(); // Ожидаем, чтобы пользователь мог увидеть результат перед завершением программы
//     }
// }

//                            Задача 2
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//                           РЕШЕНИЕ
// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1; // Если m = 0, возвращаем n + 1
//         else if (n == 0)
//             return Ackermann(m - 1, 1); // Если n = 0, рекурсивно вызываем Ackermann(m - 1, 1)
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1)); // В остальных случаях рекурсивно вызываем Ackermann
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: "); // Запрашиваем у пользователя значение m
//         int m = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в целое число

//         Console.Write("Введите значение n: "); // Запрашиваем у пользователя значение n
//         int n = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в целое число

//         int result = Ackermann(m, n); // Вычисляем значение функции Аккермана
//         Console.WriteLine($"Значение функции Аккермана A({m}, {n}) = {result}"); // Выводим результат

//         Console.ReadLine(); // Ожидаем, чтобы пользователь мог увидеть результат перед завершением программы
//     }
// }

//                          Задача 3
//Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.
//                            РЕШЕНИЕ
// using System;

// class Program
// {
//     // Метод для вывода элементов массива в обратном порядке
//     static void PrintArrayReverse(int[] arr, int index)
//     {
//         if (index >= 0)
//         {
//             Console.WriteLine(arr[index]); // Выводим текущий элемент
//             PrintArrayReverse(arr, index - 1); // Рекурсивно вызываем для предыдущего элемента
//         }
//     }

//     static void Main()
//     {
//         int[] myArray = { 10, 20, 30, 40, 50 }; // Произвольный массив

//         Console.WriteLine("Элементы массива в обратном порядке:");
//         PrintArrayReverse(myArray, myArray.Length - 1); // Начинаем с последнего элемента

//         Console.ReadLine();
//     }
// }

//                     Задача 1
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

                    //   Решение


// System.Console.WriteLine("Введите значение M:");
// int M = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Введите значение N:");
// int N = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Натуральные числа от M до N:");
// PrintNumbers(M, N);

// void PrintNumbers(int M, int N)
// {
//     if (M > N) // Условие остановки рекурсии
//     {
//         return;
//     }

//     System.Console.WriteLine(M); // Вывод текущего числа
//     PrintNumbers(M + 1, N); // Вызов функции с увеличением M
// }

                // Задача 2

//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

                // Решение
// Ввод значений m и n
// System.Console.WriteLine("Введите значение m:");
// int m = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Введите значение n:");
// int n = Convert.ToInt32(System.Console.ReadLine());

// // Вычисление функции Аккермана
// int result = Ackermann(m, n);
// System.Console.WriteLine($"Функция Аккермана A({m}, {n}) = {result}");

// // Рекурсивная функция для вычисления функции Аккермана
// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
//     return 0; // Это не должно достигаться
// }

                    // Задача 3
//Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

//Запрос ввода длины массива
// System.Console.WriteLine("Введите длину массива:");
// int length = Convert.ToInt32(System.Console.ReadLine());

// // Создание массива заданной длины
// int[] array = new int[length];

// // Заполнение массива элементами, введенными с консоли
// for (int i = 0; i < length; i++)
// {
//     System.Console.WriteLine($"Введите элемент {i + 1}:");
//     array[i] = Convert.ToInt32(System.Console.ReadLine());
// }

// System.Console.WriteLine("Элементы массива в обратном порядке:");
// PrintArrayReverse(array, array.Length - 1);

// // Рекурсивная функция для вывода массива в обратном порядке
// void PrintArrayReverse(int[] array, int index)
// {
//     if (index < 0) // Условие остановки рекурсии
//     {
//         return;
//     }

//     System.Console.WriteLine(array[index]); // Вывод текущего элемента
//     PrintArrayReverse(array, index - 1); // Вызов функции с уменьшенным индексом
// }
