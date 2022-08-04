
/*

Задача №26
Напишите программу, которая принимает на вход
число и выдаёт количество цифр в числе.
Пример:
456 -> 3
78 -> 2
89126 -> 5

*/

Console.Clear();

Console.Write("Введите число: ");

// int sumOfNumbers;
string inputLineNumber = Console.ReadLine() ?? "";  // ??""  -  чтобы на Null не ругался
long inputNumber = long.Parse(inputLineNumber);
Console.WriteLine ("----------------------------------------------");


long CharVersion()
{
    // return inputLineNumber.ToCharArray().Length;

    // The same
    
    long numberLength = 0;
    char[] array = inputLineNumber.ToCharArray();
    numberLength = array.Length;
    return numberLength;
    
}

long SimpleVersion()
{
    long numberLength = 0;
    long digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

long Log10Version()
{
    return (long)Math.Log10(inputNumber) + 1;
}

long result = 0;

result = CharVersion();
DateTime timePoint = DateTime.Now;
Console.WriteLine("Длина введённого числа = " + result);
Console.Write("Время подсчёта CharVersion: ");
Console.WriteLine (DateTime.Now - timePoint);
Console.WriteLine ("----------------------------------------------");

result = SimpleVersion();
Console.WriteLine("Длина введённого числа = " + result);
Console.Write("Время подсчёта SimpleVersion: ");
Console.WriteLine (DateTime.Now - timePoint);
Console.WriteLine ("----------------------------------------------");


result = Log10Version();
//Console.WriteLine(result);
Console.WriteLine("Длина введённого числа = " + result);
Console.Write("Время подсчёта Log10Version: ");
Console.WriteLine (DateTime.Now - timePoint);
Console.WriteLine ("----------------------------------------------");

// Console.Write("Длина введённого числа = " + result);
// result = SimpleVersion();
// Console.Write("Длина введённого числа = " + result);
// Log10Version();


// sumOfNumbers = SimpleVersion();

// Console.WriteLine("Сумма чисе от 1 до " + inputNumber + " = " + sumOfNumbers);
// Console.WriteLine("Сумма чисе от 1 до " + inputNumber + " = " + sumOfNumbers);
