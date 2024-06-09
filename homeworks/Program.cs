//                           Программа поиска большего значения из двух
// bool CompareNumbers (int x, int y)
// {
//     if(x > y)
//     {
//         return true;
//     }
//     return false;
// }

// void Result (int x, int y)
// {
//     if(CompareNumbers(x,y))
// {
//     System.Console.WriteLine($"firstNumber = {x} more secondNumber = {y}");
// }
// else
// {
//     System.Console.WriteLine($"firstNumber = {x} less secondNumber = {y}");
// }
// }

// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Result (x,y);

//                             РЕШЕНИЕ КОПИЛОТ
// using System;

// class Program
// {
//     // Метод для сравнения двух чисел
//     static bool CompareNumbers(int x, int y)
//     {
//         return x > y;
//     }

//     // Метод для вывода результата сравнения
//     static void Result(int x, int y)
//     {
//         if (x == y)
//         {
//             Console.WriteLine($"firstNumber = {x} is equal to secondNumber = {y}");
//         }
//         else if (CompareNumbers(x, y))
//         {
//             Console.WriteLine($"firstNumber = {x} is more than secondNumber = {y}");
//         }
//         else
//         {
//             Console.WriteLine($"firstNumber = {x} is less than secondNumber = {y}");
//         }
//     }

//     static void Main(string[] args)
//     {
//         // Ввод первого числа
//         Console.WriteLine("Input first number: ");
//         int x = Convert.ToInt32(Console.ReadLine());

//         // Ввод второго числа
//         Console.WriteLine("Input second number: ");
//         int y = Convert.ToInt32(Console.ReadLine());

//         // Вызов метода для вывода результата
//         Result(x, y);
//     }
// }

//                                            ИСКОМОЕ РЕШЕНИЕ ЗАДАЧИ

// Введите свое решение ниже
// if (firstNumber > secondNumber)
//         {
//             Console.WriteLine("первое число больше");
//         }
//         else if (firstNumber < secondNumber)
//         {
//             Console.WriteLine("второе число больше");
//         }
//         else
//         {
//             Console.WriteLine("числа равны");
//         }
//     }

    

  // Не удаляйте и не меняйте метод Main! 
