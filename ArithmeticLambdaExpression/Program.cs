/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу, в которой создайте четыре лямбда оператора для выполнения
арифметических действий, первый лямбда оператор для сложения, второй для вычитания,
третий для умножения и четвертый для деления (лямбда оператор для деления должен
выполнять проверку деления на ноль). Каждый лямбда оператор должен принимать два
аргумента и возвращать соответственный результат вычисления. В программе организуйте
логику, которая будет выполнять арифметическую операцию указанную пользователем.
*/

var addition = (int x, int y) => x + y;
var subtract = (int x, int y) => x - y;
var multiply = (int x, int y) => x + y;
var division = (int x, int y) =>
{
    try
    {
        if (y == 0)
            throw new DivideByZeroException();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Деление на ноль невозможно!");
        Environment.Exit(0);
    }
    return x / y;
};

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите знак арифметической операции:");
var sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Console.WriteLine(addition(a, b));
        break;
    case "-":
        Console.WriteLine(subtract(a, b));
        break;
    case "*":
        Console.WriteLine(multiply(a, b));
        break;
    case "/":
        Console.WriteLine(division(a, b));
        break;
    default:
        Console.WriteLine("Операция не определена");
        break;
}