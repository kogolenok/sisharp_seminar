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

//         TASK2
//Задать массив случайных чисел N, 
//который вводится с клавиатуры
//найти кол-во чисел одновременно оканчивающихся
//на 1 и делящихся на цело на 7
//н.р. (1 5 11 21 91)
//ответ 2 

              //РЕШЕНИЕ
//num = num +(*-) 1; => num +(*-)=

// int[] InputArray(int size)//это метод создающий массив
// //здесь создаём и заполняем массив, и возвращаем
// {
//     int[] arr = new int[size];// массив с размером size
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine($"Input {i + 1} number: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }
// //пишем метод, который и будет считать кол-во элементов массива
// int ArrayCounter(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// //запрошу размер массива
// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// //теперь вызову метод для ввода массива
// int[] arr = InputArray(size);
// //теперь когда есть массив найдём наши числа
// System.Console.WriteLine(ArrayCounter(arr));

               //TASK 3
//Ввести с консоли массив случайных чисел
//от 0 до 9 и записать эти цифры как одно число
//старший разряд числа находится на 0-м индексе
//младший на - на последнем
//н.р. 3 2 1 - 321
//1 3 2 4 - 1324

               //РЕШЕНИЕ

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array [i] = random.Next(0, 9 + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//   for(int i = 0; i < array.Length; i++)
//   {
//     System.Console.Write(array[i] + " ");//здесь если WriteLine
//     //если выше WriteLine написать то он в столбец будет выводить
//   }  
//   System.Console.WriteLine();
// }

// int NumberOfArray (int[] array)
// {
//     int number = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         number += array[i] * (int)Math.Pow(10, (array.Length - i-1));
//     }
//     return number;
// }
// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// int result = NumberOfArray(myArray);
// PrintArray(myArray);
// System.Console.WriteLine(result);
