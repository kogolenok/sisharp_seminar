//                 ARRAY
//          TASK1
// задать массив
//определить есть ли число 
//в этом массиве выводить Да или Нет
//н.р. (1,2,3,5) - 6 - нет
//н.р. (1,2,3,4,5) 2 - да
// метод задающий массив
//int [] - говорит, что возвращаться будет массив, а не число
// дальше назовём его (как угодн)
//н.р. CreateRandomArray()
// int[] CreateRandomArray(int size, int min, int max)
// {
// int[] array = new int[size];
// Random random = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(min, max + 1);
// //     //max+1-чтобы последняя цифра массива включительно
// }
// return array;
// }
// void PrintArray(int[] array)  //он выведет и закончит работу
// {
// for(int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i] + " ");  //Просто Write
// }
// System.Console.WriteLine();
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

