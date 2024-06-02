

// Console.WriteLine("Input number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Quard of" + x + " is " +x*x);

// 1 Задание является ли число квадратом другого н.р. x=4 y=2 - yes

// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x == y*y)
// {
//     Console.WriteLine($"x = {x}, y = {y}->yes");
// }
// else
// {
//   Console.WriteLine($"x = {x}, y = {y}->no");
// }  



// ЗАДАНИЕ 2
// Написать программу принимающую на вход число N а на выходе n-1
// н.р. 2-> -2-1 0 1 2

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while (start <= n)
// {
// System.Console.Write(start + " ");
// start++;//start=start+1
// }

//ЗАДАНИЕ 3
//Входит н-х значное число, а выходит сумма 1-й и 3-й цифры 3-х значного числа
// но сначала условие проверки на 3-х значность 

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num <= 999)// проверяем на 3-х значность
{
int ed = num % 10; //456%10=6
int sot = num / 100; //456/100=4
System.Console.WriteLine("sum =" + (ed + sot));
}
else
{
    System.Console.WriteLine("You input not three digit number");
}
