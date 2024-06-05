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

//написать программу где вводится 3-х значное число и удаляется 2-я цифра этого числа Н.р. 256 - 26, 891 - 84


//Сначала нужно определить 3-х значное число или нет
//bool либо да либо нет

bool IsThreeDigit(int num)
{
    if(num > 99 && num < 1000)
    {
        return true;
    }
    return false;
}

//теперь напишем функцию, которая удалит 2-ю цифру 3-х значного числа

int DeleteSecondDigit(int num)
{
    if(IsThreeDigit(num))
    {
        int ed = num % 10;
        int sot = num / 100;
        return ed + sot * 10;
    }
    else
    {
        System.Console.WriteLine("You input no Three-digit number");
        return 0; //если число не 3-х значное выводить что то всё равно должен Н.р. n
    }
}

System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DeleteSecondDigit(a));
