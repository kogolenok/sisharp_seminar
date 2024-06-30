//                Задача 1: 
//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.  

            //РЕШЕНИЕ
// using System;: Эта строка подключает пространство имен System, 
// которое содержит базовые классы и функциональность .NET Framework. 
// Пространство имен System предоставляет доступ к многим важным типам данных, 
// методам и классам, таким как Console, Math, DateTime и другие. 
// Без этой строки мы не смогли бы использовать эти функции в нашей программе.
// class Program: Здесь объявляется класс Program. Класс Program является 
// точкой входа в нашу программу. В методе Main этого класса мы начинаем 
// выполнение программы.
// Эти строки обеспечивают базовую функциональность и структуру программы. 
// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем двумерный массив символов
//         char[,] charArray = new char[,]
//         {
//             { 'O', 'l', 'e', 'g' }, // Первая строка
//             { 'P', 'e', 't', 'r' }  // Вторая строка
//         };

//         // Формируем строку из символов массива
//         string result = GetStringFromCharArray(charArray);

//         // Выводим строку в два ряда с пробелами
//         for (int i = 0; i < result.Length; i++)
//         {
//             Console.Write(result[i] + " "); // Выводим символ с пробелом
//             if (i == charArray.GetLength(1) - 1)
//                 Console.WriteLine(); // Переход на новую строку
//         }
//     }

//     // Метод для формирования строки из символов массива
//     static string GetStringFromCharArray(char[,] array)
//     {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         char[] charString = new char[rows * cols];
//         int index = 0;

//         for (int row = 0; row < rows; row++)
//         {
//             for (int col = 0; col < cols; col++)
//             {
//                 charString[index] = array[row, col];
//                 index++;
//             }
//         }

//         return new string(charString);
//     }
// }

//                          Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
//                          РЕШЕНИЕ
// Для решения этой задачи мы можем использовать метод ToLower()
// using System;

// class Program
// {
//     static void Main()
//     {
//         string originalString = "OLEg PeTRoVich"; // Задаем исходную строку

//         // Преобразуем все символы в нижний регистр
//         string result = originalString.ToLower();

//          // Выводим исходную строку
//         Console.WriteLine("Исходная строка: " + originalString);

//         // Выводим строку с нижним регистром
//         Console.WriteLine("Строка с нижним регистром: " + result);
//     }
// }

//                         Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

// Палиндром - это слово, фраза или последовательность 
// символов, которая читается одинаково в обоих направлениях 
// (слева направо и справа налево).
//                      РЕШЕНИЕ
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

//         bool isPalindrome = IsPalindrome(input);

//         if (isPalindrome)
//             Console.WriteLine("Строка является палиндромом.");
//         else
//             Console.WriteLine("Строка не является палиндромом.");
//     }

//     static bool IsPalindrome(string str)
//     {
//         // Удаляем пробелы и приводим к нижнему регистру
//         str = str.Replace(" ", "").ToLower();

//         int left = 0;
//         int right = str.Length - 1;

//         while (left < right)
//         {
//             if (str[left] != str[right])
//                 return false;

//             left++;
//             right--;
//         }

//         return true;
//     }
// }

// В этом примере:

// Мы удаляем пробелы из строки и приводим все символы к нижнему регистру.
// Затем сравниваем символы слева и справа, двигаясь к центру строки.
// Если символы не совпадают, строка не является палиндромом.

//                         Задача 4:
//  Задайте строку, состоящую из слов, разделенных пробелами. 
//  Сформировать строку, в которой слова расположены в обратном порядке. 
//  В полученной строке слова должны быть также разделены пробелами.
//                          РЕШЕНИЕ
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

//         string reversedSentence = ReverseWords(input);

//         Console.WriteLine("Строка с обратным порядком слов: " + reversedSentence);
//     }

//     static string ReverseWords(string sentence)
//     {
//         string[] words = sentence.Split(); // Разделяем строку на слова
//         Array.Reverse(words); // Переворачиваем порядок слов
//         return string.Join(" ", words); // Объединяем слова обратно в строку
//     }
// }
// В этом примере:

// Мы разделяем введенную строку на слова с помощью метода Split().
// Затем переворачиваем порядок слов с помощью метода Array.Reverse().
// И, наконец, объединяем слова обратно в строку с помощью метода string.Join().