// №27 Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки

Console.Clear();

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
long a = long.Parse(inputLine ?? "");
long b = 0;

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

Console.Write(calculation());