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

  //                               ЗАДАЧА2

//Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

//using System; ЭТА СТРОКА ДОЛЖНА БЫТЬ НЕ АКТИВНА, ТОГДА РАБОТАЕТ

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже ЭТО И ЕСТЬ РЕШЕНИЕ

// return Math.Max(a, Math.Max(b, c));

//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 8;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

//                             ЗАДАЧА 3

//Внутри класса Answer напишите метод CheckIfEven, который на вход принимает 
//число number и выводит, является ли число чётным (делится ли оно на два без остатка).

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
// if (number % 2 == 0)
//       {
//           Console.WriteLine($"{number} is even.");
//       }
//       else
//       {
//           Console.WriteLine($"{number} is odd.");
//       }

//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 98;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

//                                 ЗАДАЧА4

//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
//а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

public class Answer {
    
  static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      for (int i = 1; i <= number; i++)
      {
          if (i % 2 == 0)
          {
              Console.Write($"{i} ");
          }
      }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}