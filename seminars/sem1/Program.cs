

// Console.WriteLine("Input number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Quard of" + x + " is " +x*x);

// 1 Задание является ли число квадратом другого н.р. x=4 y=2 - yes

Console.WriteLine("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == y*y)
{
    Console.WriteLine($"x = {x}, y = {y}->yes");
}
else
{
  Console.WriteLine($"x = {x}, y = {y}->no");
}  



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

