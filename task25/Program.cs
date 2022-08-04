
// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

Console.Clear();

long a;
long b;

void Read()
{
    Console.Write("Введите число: ");
    string? inputA = Console.ReadLine();
    a = long.Parse(inputA??"");

    Console.Write("В какую степень его возвести: ");
    string? inputB = Console.ReadLine();
    b = long.Parse(inputB??"");
}

long calculation(long a, long b)
{
    long i = 0;
    long result = 1;
    while (i < b)
    {
        result *= b;
        i++;
    }
    return result;
}

void Print()
{
    Console.WriteLine(a + " в степени " + b + " = " + calculation(a, b));    
}

Read();

Print();