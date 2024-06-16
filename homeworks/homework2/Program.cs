//                2-ой семинар( Простые алгоритмы)

//            Задача 1: 
//Проверка кратности числа 7 и 23 н.р.:
// a=50 => нет
// a=7 => нет
// a=322 => да

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     System.Console.WriteLine("Число кратно и 7, и 23");
// }
// else
// {
//     System.Console.WriteLine("Число не кратно одновременно 7 и 23");
// }

//                     Задача 2:
// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
//н.р.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4
// System.Console.WriteLine("Input coordinate X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
//     Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0)
//     Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0)
//     Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0)
//     Console.WriteLine("Четвертая четверть");

//                    Задача 3:
// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// н.р.
// 40 => 4
// 96 => 9
// 72 => 7

// System.Console.WriteLine("Enter an integer from 10 to 99: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;

//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//     System.Console.WriteLine("Largest digit of the number: " + maxDigit);
// }
// else
// {
//     System.Console.WriteLine("The number is not in the specified range.");
// }

//                  Задача 4:
//  Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.
// н.р.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

// System.Console.Write("Input number N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digits of N separated by commas:");
// PrintDigits(N);

// static void PrintDigits(int number)
// {
//     if (number < 10)
//     {
//         Console.Write(number);
//     }
//     else
//     {
//         PrintDigits(number / 10);
//         Console.Write($", {number % 10}");
//     }
// }


