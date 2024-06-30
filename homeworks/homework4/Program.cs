//				Урок 4. Функции
//                        Задача 1: 
//Напишите программу, которая бесконечно 
//запрашивает целые числа с консоли. 
//Программа завершается при вводе символа 
//‘q’ или при вводе числа, сумма цифр которого чётная.

//                         РЕШЕНИЕ

// using System;
// namespace InfiniteNumberInput
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("Введите целое число (или 'q' для выхода): ");
//                 string input = Console.ReadLine();
//                 if (input.ToLower() == "q")
//                 {
//                     Console.WriteLine("Программа завершена.");
//                     break;
//                 }
//                 if (int.TryParse(input, out int number))
//                 {
//                     int sumOfDigits = 0;
//                     int tempNumber = Math.Abs(number);
//                     while (tempNumber > 0)
//                     {
//                         sumOfDigits += tempNumber % 10;
//                         tempNumber /= 10;
//                     }
//                     if (sumOfDigits % 2 == 0)
//                     {
//                         Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
//                         break;
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
//                 }
//             }
//         }
//     }
// }


//			Задача 2: 
//Задайте массив заполненный случайными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

//                          РЕШЕНИЕ

// using System;
// namespace EvenNumbersInArray
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] randomNumbers = new int[10]; // Массив из 10 элементов
//             // Заполняем массив случайными трёхзначными числами
//             Random random = new Random();
//             for (int i = 0; i < randomNumbers.Length; i++)
//             {
//                 randomNumbers[i] = random.Next(100, 1000);
//             }
//             // Подсчитываем количество чётных чисел
//             int evenCount = 0;
//             foreach (int number in randomNumbers)
//             {
//                 if (number % 2 == 0)
//                 {
//                     evenCount++;
//                 }
//             }
//             Console.WriteLine($"Массив случайных чисел: [{string.Join(", ", randomNumbers)}]");
//             Console.WriteLine($"Количество чётных чисел: {evenCount}");
//         }
//     }
// }


//                                 Задача 3: 
//Напишите программу, которая перевернёт 
//одномерный массив (первый элемент станет 
//последним, второй – предпоследним и т.д.)

//                     РЕШЕНИЕ

// using System;
// namespace ReverseArray
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] originalArray = { 1, 2, 3, 4, 5 };
//             Console.WriteLine("Исходный массив:");
//             PrintArray(originalArray);
//             // Переворачиваем массив
//             ReverseArray(originalArray);
//             Console.WriteLine("Перевернутый массив:");
//             PrintArray(originalArray);
//         }
//         static void ReverseArray(int[] arr)
//         {
//             int left = 0;
//             int right = arr.Length - 1;
//             while (left < right)
//             {
//                 int temp = arr[left];
//                 arr[left] = arr[right];
//                 arr[right] = temp;
//                 left++;
//                 right--;
//             }
//         }
//         static void PrintArray(int[] arr)
//         {
//             foreach (int num in arr)
//             {
//                 Console.Write(num + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



