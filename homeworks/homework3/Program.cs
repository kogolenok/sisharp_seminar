// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

// решение

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//          //Введите сюда свое решение
//       // Считаем количество элементов, которые лежат в заданном диапазоне
//         int count = 0;
//         foreach (int num in numbers)
//         {
//             if (num >= minRange && num <= maxRange)
//             {
//                 count++;
//             }
//         }
//         return count;
//      }
    
//     public static void PrintResult(int[] array)
//     {
        
//           //Введите сюда свое решение
//       // Определяем границы диапазона
//         int minRange = 10;
//         int maxRange = 90;

//         // Вызываем метод для подсчета количества элементов в диапазоне
//         int result = CountItemsRange(array, minRange, maxRange);

//         // Выводим результат
//         Console.WriteLine(result);
//        }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


// ЗАДАЧА 2

// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Начальные условия:
// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

// РЕШЕНИЕ

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//       // Инициализируем счётчик чётных чисел
//         int count = 0;

//         // Перебираем каждый элемент массива
//         foreach (int num in numbers)
//         {
//             // Проверяем, является ли число чётным
//             if (num % 2 == 0)
//             {
//                 count++;
//             }
//         }
        
//         // Возвращаем количество чётных чисел
//         return count;
//     }
    
//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//       // Вызываем метод для подсчета чётных чисел
//         int evenCount = CountEvenItems(array);
        
//         // Выводим результат
//         Console.WriteLine(evenCount);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


// ЗАДАЧА 3

// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// Начальные условия:
// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15
// решение

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива
    
//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         //Напишите свое решение здесь
//       return numbers.Min();
//     }
    
//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         //Напишите свое решение здесь
//       return numbers.Max();
//     }
    
    
    
//     public static void PrintResult(double[] array)
//     {
//         //Напишите свое решение здесь
//       double min = FindMin(array);
//     double max = FindMax(array);
//     double difference = max - min;
//     Console.WriteLine(difference);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }
