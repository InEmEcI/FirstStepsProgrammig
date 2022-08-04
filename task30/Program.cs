
// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

Console.Clear();

System.Random numberSintezator = new Random();

void NaiveVersion()
{
    int i = 0;
    Console.Write("[");
    while(i < 8 - 1)
    {
        Console.Write(numberSintezator.Next(0,2) + ",");
        //Console.Write(",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,2));
    Console.Write("]");
}

NaiveVersion();

