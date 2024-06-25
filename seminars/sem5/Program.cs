// //      Метод создания и заполнения 2-у мерного массива
// //эта функция будет создавать случайную матрицу
// int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];//выделение памяти для массива
//     //создам объект класса рандом
//     Random random = new Random();//random- название, можно любое
//     //это уже массив но с нулевыми значениями
//     //заполним массив числами
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             //заполняем массив
//             matrix[i, j] = random.Next(min, max + 1);
//             //метод Next генерирует значения от 0 до 9
//         }
//     }
//     //после заполнения массива, нужно его вернуть:
//     return matrix;
// }

// //далее войдовский метод, ему возвращать ни чего не надо
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)//0 возвращает кол-во строк
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)// 1 число столбцов
//         {
//                 System.Console.Write(matrix[i, j] + " ");
//        }
//        System.Console.WriteLine();
//     }
// }
// PrintMatrix(CreateRandomMatrix(4, 4, 0, 9));//пока вручную 4 4 0 9


