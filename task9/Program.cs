
Console.Clear();

System.Random numberSintezator = new Random();

// Вариант 1
void variant1()
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Вариант 1");

    int number = numberSintezator.Next(10, 100);

    Console.WriteLine(number);

    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}
variant1();

// Вариант 2
void variant2()
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Вариант 2");
    int numberKirilla = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(numberKirilla);
    string stringNum = numberKirilla.ToString();
    Console.Write("The biggest digit is: ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
};
variant2();

// Вариант 3
void variant3()
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Вариант 3");
    char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

    Console.Write("Рандомное число: "); Console.WriteLine(digits);

    int firstNumber = ((int)digits[0] - 48);
    int secondNumber = ((int)digits[1] - 48);

    int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;
    Console.Write("бОльшее из его цифр: "); Console.WriteLine(resultNumber);
    Console.WriteLine("-----------------------------");
}
variant3();
