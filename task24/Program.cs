/*

Задача №24
Напишите программу, которая принимает на вход
число (А) и выдаёт сумму чисел от 1 до А.
Например:
7 -> 28
4 -> 10
8 -> 36

*/

Console.Clear();

Console.Write("Введите число: ");

long inputNumber = long.Parse(Console.ReadLine());

Console.WriteLine();



// the classic version
void SimpleVersion()
{
    long sumOfNumbers = 0;
    for (int i = 0; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
        // the same
        // sumOfNumbers = sumOfNumbers + i;
    }

    Console.WriteLine("Сумма чисе от 1 до " + inputNumber + " = " + sumOfNumbers);
}

// the Gauss version
void GaussVersion()
{
    long sumOfNumbers = 0;
    sumOfNumbers = ((inputNumber + 1) * inputNumber) / 2;
    Console.WriteLine("Сумма чисе от 1 до " + inputNumber + " = " + sumOfNumbers);
}

int t = Environment.TickCount;
Console.WriteLine("Простой метод");
SimpleVersion();
Console.WriteLine("Время выполнения: " +  (Environment.TickCount - t) + " ms");
Console.WriteLine();


t = Environment.TickCount;
Console.WriteLine("Метод Гаусса");
GaussVersion();
Console.WriteLine("Время выполнения: " +  (Environment.TickCount - t) + " ms");