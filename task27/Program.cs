// №27 Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки


Console.Clear();

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

Console.WriteLine("--------------------------------");

// algorithm using strings
DateTime timePoint = DateTime.Now;
int result = inputLine.Sum(c => c - '0');
Console.WriteLine("Algorithm using strings");
Console.WriteLine("Сумма цифр в числе " + inputLine + " = " + result);
Console.Write("Время подсчёта: ");
Console.WriteLine (DateTime.Now - timePoint);
Console.WriteLine("--------------------------------");

// algorithm using real numbers
long a = long.Parse(inputLine ?? "");
long b = 0;
timePoint = DateTime.Now;
long calculation()
{
    while (a > 0)
    {
        b = b + a % 10;
        a = a / 10;
    }
    // Console.Write(b);
    return(b);
}


Console.WriteLine("Algorithm using real numbers");
Console.WriteLine("Сумма цифр в числе " + inputLine + " = " + result);
Console.Write("Время подсчёта: ");
Console.WriteLine (DateTime.Now - timePoint);
Console.WriteLine("--------------------------------");