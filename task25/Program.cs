// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

Console.Clear();

double a;
double b;
string operation = string.Empty;


Console.Write("Первое число: ");
string? inputA = Console.ReadLine();
a = double.Parse(inputA ?? "");

// арифметическое действие
Console.Write("Операция: ");
operation = Console.ReadLine() ?? "";

Console.Write("Второе число: ");
string? inputB = Console.ReadLine();
b = double.Parse(inputB ?? "");

void calculation()
{
    if (operation == "+")
    {
        Console.Write(a + " " + operation + " " + b + " = " + (a + b));
    }
    else

    if (operation == "-")
    {
        Console.Write(a + " " + operation + " " + b + " = " + (a - b));
    }
    else

    if (operation == "*")
    {
        Console.Write(a + " " + operation + " " + b + " = " + (a * b));
    }
    else

    if (operation == "/")
    {
        Console.Write(a + " " + operation + " " + b + " = " + (a / b));
    }
    else

    if (operation == "^")
    {
        Console.Write(a + " " + operation + " " + b + " = " + (Math.Pow(a, b)));
    }
    else
    {
        Console.Write("Ошибка ввода! Операциями может быть только  +  -  *  /  или ^ ");
    }

}

calculation();