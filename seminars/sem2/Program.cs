// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//методы-функции
//int Pow (int n)
//{
//    return n*n;
//} 
//System.Console.WriteLine("Input number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine(Pow(a));//если здесь убрать System.Console.WriteLine, а оставить просто Pow(a), выведет просто введённое число
//можно ввести переменную int result = Pow (a); и вывести System.Console.WriteLine(result)
//т.е. System.Console.WriteLine("Input number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int result = Pow(a);
//System.Console.WriteLine(result);

//Но функция может и не возвращать данные, применяется функция void
// Использование void
int Pow (int n)
{
    return n*n;
} 
void Pow2(int n)

{
    System.Console.WriteLine($"Quard of {n} -> {n*n}");
}

System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Pow2(a);