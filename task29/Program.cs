
// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 
// * 
// Ввести с клавиатуры длину массива и диапазон значений элементов 
// три числа:
// arrayLength - длина массива
// a - от
// b - до


// про рандомный выбор имени того, кто побежит за пивом смотреть описание примерно на 2 ч. 00 мин.
// нужно работу со строками подробней изучить!


Console.Clear();


//Буфферные переменные
int i = 0;
int j = 0;

Console.Write("Введите длину массива: ");
string? inputLine = Console.ReadLine() ?? "";
int arrayLength = int.Parse(inputLine); // длинна массива
int[] array = new int[arrayLength];


// RangeOfArrayElementsRead();
ArrayFilling();

Console.WriteLine("Введите диапозон значений: ");

int a = inputA(); // от
int b = inputB(); // до

int inputA()
{
    Console.Write("от: ");
    string? inputA = Console.ReadLine() ?? "";
    int numberA = int.Parse(inputA); // от
    return numberA;
}

int inputB()
{
    Console.Write("до: ");
    string? inputB = Console.ReadLine() ?? "";
    int numberB = int.Parse(inputB); // до
    return numberB;
}

void ArrayFilling()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();

    //Цикл заполнения массива и вывода его на экран
    while (i < arrayLength)
    {
        //Получаем новое значение    
        array[i] = numberSintezator.Next(-100, 100);

        //вывод на экран
        Console.Write(array[i] + " ");

        // инкримент
        i++;
    }
    Console.WriteLine();
}

void Print()
{
    i = 0;

    if (a > arrayLength || b > arrayLength)
    {
        Console.Write("Число больше или меньше длины массива! ");
    }
    else if (a < b)
    {
        while (i < b)
        {
            Console.Write(array[(a - 1) + i] + " ");
            i++;
        }
    } else if (a > b)
    {
        while (j < a)
        {
            Console.Write(array[(a - j) - 1] + " ");
            j++;
        }
    } else if(a == b)
    {
        Console.Write(array[a - 1]);
    }
}

Print();