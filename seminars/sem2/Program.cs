﻿
//              Рандомный выбор
// System.Console.WriteLine(new Random().Next(1,29));

// методы-функции
// int Pow (int n)
// {
//    return n*n;
// } 
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Pow(a));//если здесь убрать System.Console.WriteLine, а оставить просто Pow(a), выведет просто введённое число
// можно ввести переменную int result = Pow (a); и вывести System.Console.WriteLine(result)
// т.е. System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Pow(a);
// System.Console.WriteLine(result);

// Но функция может и не возвращать данные, применяется функция void
// Использование void
// int Pow (int n)
// {
//     return n*n;
// } 
// void Pow2(int n)

// {
//     System.Console.WriteLine($"Quard of {n} -> {n*n}");
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Pow2(a);

//                  TASK1

// написать программу где вводится 3-х значное число и удаляется 2-я цифра этого числа Н.р. 256 - 26, 891 - 84


// Сначала нужно определить 3-х значное число или нет
// bool либо да либо нет

// bool IsThreeDigit(int num)
// {
//     if(num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// // //теперь напишем функцию, которая удалит 2-ю цифру 3-х значного числа

// int DeleteSecondDigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return ed + sot * 10;
//     }
//     else
//     {
//         System.Console.WriteLine("You input no Three-digit number");
//         return 0; //если число не 3-х значное выводить что то всё равно должен Н.р. n
//     }
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeleteSecondDigit(a));

// Если бы делал этот метод Void то выглядело бы так:

// bool IsThreeDigit(int num)
// {
//     if(num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// теперь напишем функцию, которая удалит 2-ю цифру 3-х значного числа
// При void здесь вместо int пишу void и удаляю return 0 в 94 строке
// void DeleteSecondDigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         //Здесь вместо return ed + ... сразу вывод
//         System.Console.WriteLine(ed + sot * 10);
//     }
//     else
//     {
//         System.Console.WriteLine("You input no Three-digit number");
//         //Здесь был return 0;
//     }
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// //здесь system.console убираем
// DeleteSecondDigit(a);

//                             TASK2

// Программа которая в трёхзначном числе
// возведёт 2-ю цифру в степень равную 3-й цифре
// н.р. 123-2^3=8

// bool IsThreeDigit(int num)
// {
//     if(num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondThoThirdPower(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         System.Console.WriteLine(Math.Pow(dec, ed));
//     }
//     else
//     {
//         System.Console.WriteLine("You input no Three-digit number");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// SecondThoThirdPower(a);


//                           TASK3

// Написать программу где на входе будет 2 числа
// выводить является ли 1-е кратным второму
// если не кратно то выводит остаток от деления
// н.р. 14 и 5 -нет = 4
// 16 и 8 - да и т.д.

// bool Multiplisity (int x, int y)
// {
//     if(x % y == 0)
//     {
//         return true;
//     }
//     return false;
// }

// void Result (int x, int y)
// {
//     if(Multiplisity(x,y))
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
//     System.Console.WriteLine($"No, {x % y}");
// }
// }

// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Result (x,y);






