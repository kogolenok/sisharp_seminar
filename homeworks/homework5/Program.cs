// // //            Д.з. Двумерные массивы
          
// //           //Задача 1
// // Строка с наименьшей суммой элементов


// // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // Начальные условия:

// // // Начальные условия
// // int[,] numbers = new int[,] {
// //     {1, 2, 3},
// //     {1, 1, 0},
// //     {7, 8, 2},
// //     {9, 10, 11}
// // };
// // Выводится: 1

// //                         РЕШЕНИЕ
// // using System;

// // //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// // class UserInputToCompileForTest
// // {
// //     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
// //     public static int[] SumRows(int[,] array)
// //     {
// //       //Напишите свое решение здесь
// //        int rows = array.GetLength(0);
// //         int cols = array.GetLength(1);
// //         int[] sums = new int[rows];

// //         for (int i = 0; i < rows; i++)
// //         {
// //             int sum = 0;
// //             for (int j = 0; j < cols; j++)
// //             {
// //                 sum += array[i, j];
// //             }
// //             sums[i] = sum;
// //         }
// //         return sums;
// //     }
    
// //     // Получение индекса минимального элемента в одномерном массиве
// //     public static int MinIndex(int[] array)
// //     {
// //        //Напишите свое решение здесь
// //        if (array.Length == 0) return -1; // если массив пустой, возвращаем -1

// //         int minIndex = 0;
// //         int minValue = array[0];

// //         for (int i = 1; i < array.Length; i++)
// //         {
// //             if (array[i] < minValue)
// //             {
// //                 minValue = array[i];
// //                 minIndex = i;
// //             }
// //         }
// //         return minIndex;
// //     }
// //     public static void PrintResult(int[,] numbers)
// //     {   
// //        //Напишите свое решение здесь
// //        int[] rowSums = SumRows(numbers);
// //         int minRowIndex = MinIndex(rowSums);
// //         Console.WriteLine(minRowIndex);
// //     }
// // }

// // //Не удаляйте и не меняйте класс Answer!
// // class Answer
// // {
// //     public static void Main(string[] args)
// //     {
// //         int[,] numbers;

// //         if (args.Length >= 1)
// //         {
// //             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
// //             string[] rows = args[0].Split(',');

// //             int rowCount = rows.Length;
// //             int colCount = rows[0].Trim().Split(' ').Length;

// //             numbers = new int[rowCount, colCount];

// //             for (int i = 0; i < rowCount; i++)
// //             {
// //                 string[] rowElements = rows[i].Trim().Split(' ');

// //                 for (int j = 0; j < colCount; j++)
// //                 {
// //                     if (int.TryParse(rowElements[j], out int result))
// //                     {
// //                         numbers[i, j] = result;
// //                     }
// //                     else
// //                     {
// //                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
// //                         return;
// //                     }
// //                 }
// //             }
// //         }
// //         else
// //         {
// //             // Если аргументов на входе нет, используем примерный массив
            
// //             numbers = new int[,] {
// //                 {1, 2, 3},
// //                 {1, 1, 0},
// //                 {7, 8, 2},
// //                 {9, 10, 11}
// //     };      
// //         }
// //         UserInputToCompileForTest.PrintResult(numbers);
// //     }
// // }

//                ЗАДАЧА2
               
// Верните элемент из массива по позиции
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

//           РЕШЕНИЕ

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//        if (!ValidatePosition(array, x, y))
//         {
//             if (x < 1 || x > array.GetLength(0))
//             {
//                 throw new ArgumentOutOfRangeException("Позиция по рядам выходит за пределы массива");
//             }
//             else
//             {
//                 throw new ArgumentOutOfRangeException("Позиция по колонкам выходит за пределы массива");
//             }
//         }

//         return array[x - 1, y - 1]; 
//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//        return x >= 1 && x <= array.GetLength(0) && y >= 1 && y <= array.GetLength(1);
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//         try
//         {
//             int result = FindElementByPosition(numbers, x, y);
//             Console.WriteLine(result);
//         }
//         catch (ArgumentOutOfRangeException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {
           
//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;
            
//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }

//                                ЗАДАЧА 3

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

//                РЕШЕНИЕ
// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         //Напишите свое решение здесь
//        int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

// // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         //Напишите свое решение здесь
//       int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         int[,] newArray = new int[rowCount, colCount];

//         // Копируем последнюю строку в новый массив
//         for (int j = 0; j < colCount; j++)
//         {
//             newArray[0, j] = array[rowCount - 1, j];
//         }

//         // Копируем промежуточные строки
//         for (int i = 1; i < rowCount - 1; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 newArray[i, j] = array[i, j];
//             }
//         }
    
//         // Копируем первую строку в новый массив
//         for (int j = 0; j < colCount; j++)
//         {
//             newArray[rowCount - 1, j] = array[0, j];
//         }

//         return newArray;
//     }

// // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//        //Напишите свое решение здесь
//       int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         // Проверяем, что индекс строки i входит в допустимый диапазон
//         if (i < 0 || i >= rowCount)
//         {
//             Console.WriteLine("Индекс строки выходит за пределы массива");
//             return;
//         }

//         // Индекс последней строки
//         int lastIndex = rowCount - 1;

//         // Меняем элементы местами
//         for (int j = 0; j < colCount; j++)
//         {
//             int temp = array[lastIndex, j];
//             array[lastIndex, j] = array[i, j];
//             array[i, j] = temp;
//         }
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//        int[,] swappedArray = SwapFirstLastRows(numbers);
//         PrintArray(swappedArray);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             }; 
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }
