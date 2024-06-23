//                Lesson 4 ФУНУЦИИ

//          Task 1
// Написать программу, которая на вход
//принимает число, а на выходе - кол-во
// цифр в числе
//  н.р. 458 - 3
//22 - 2
// 1-1
// РЕШЕНИЕ
// int DigitsCounter(int num)
// {
//     int counter = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         counter++;
//     }
//     return counter;
// }

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitsCounter(num));