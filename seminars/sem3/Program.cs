//               ARRAY
//       TASK1
// задать массив
// определить есть ли число 
// в этом массиве выводить Да или Нет
// н.р. (1,2,3,5) - 6 - нет
// н.р. (1,2,3,4,5) 2 - да
// метод задающий массив
//int [] - говорит, что возвращаться будет массив, а не число
// дальше назовём его (как угодно)
// н.р. CreateRandomArray()
// int[] CreateRandomArray(int size, int min, int max)
// {
// int[] array = new int[size];
// Random random = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(min, max + 1);
// //max+1-чтобы последняя цифра массива включительно
// }
// return array;
// }
// void PrintArray(int[] array)//он выведет и закончит работу
// {
// for(int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i] + " ");//Просто Write
// }
// System.Console.WriteLine();
// }
// //сделаю метод, который будет определять есть ли число в массиве
// bool SearchNum(int[] array, int num)
// {
//    for(int i = 0; i < array.Length; i++)
//    {
//     if(array [i] == num)
//     {
//         return true;
//     }
//    } 
//    return false;
// }

// System.Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, min, max);
// //System.Console.WriteLine(myArray); это метод не предназначено для вывода массива
// //нужно писать свой метод для вывода массива с 23 строки
// PrintArray(myArray);

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SearchNum(myArray, num));

//          TASK 2
//задать массив из 10 чисел (-10...10)
//заменить отрицательные - положительными
// и наоборот
// н.р. (1 -2 3) - (-1 2 -3)
//погнали

// int[] CreateRandomArray(int size, int min, int max)
// {
// int[] array = new int[size];
// Random random = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(min, max + 1);

// }
// return array;
// }

// void PrintArray(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i] + " ");  
// }
// System.Console.WriteLine();
// }


// //новый метод замены - на + и наоборот
// //тупо умножить на -1 и всё
// int[] ChangeArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// System.Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// myArray = ChangeArray (myArray);
// PrintArray(myArray);

//             TASK 3
//создать рандомный массив
//вывести новый массив - произведение пар чисел
//н.р. первое*последнее, второе*на предпоследнее

// int[] CreateArray(int size, int min, int max)
// {
// int[] array = new int[size];
// Random random = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(min, max + 1);
// }
// return array;
// }

// int[] CompositionArray(int[] array)//здесь будет функция с перемножением
// {
// int[] resultArray = new int[array.Length / 2];
// for(int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = array[i] * array[array.Length - i - 1];
// }
// return resultArray;
// }

// void PrintArray(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i] + " ");  
// }
// System.Console.WriteLine("");
// }

// System.Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// PrintArray(myArray);
// PrintArray(CompositionArray(myArray));

//при вводе 8 1 9
//выведет 
//6 4 7 6 1 3 7 6 (6*6 4*7 7*3 6*1)
//36 28 21 6




