


// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька


Console.Clear();

//Метод возвращает массив заполненый случайными числами трёхзначными числами
int[] FillingArray()
{
    int[] outArray = new int[4];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 4)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;
}

// array - изначально заполненный массив
int[] array = FillingArray();

Console.WriteLine("Массив до сортировки:");
//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + " ");
        //Увеличиваем инкремент
        i++;
    }
    // //Выводим элемент массива
    // Console.WriteLine(inputArray[i]);
}
// 
PrintIntArray(array);

// пузырьковая сортировка
void BubbleSort(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        for (int j = 0; j < mas.Length - 1 - i; j++)
        {
            if (mas[j] > mas[j + 1])
            {
                int temp = mas[j];
                mas[j] = mas[j + 1];
                mas[j + 1] = temp;
            }
        }

    for (int i = 0; i <= mas.Length - 1; i++)
    {
        Console.Write(mas[i] + " ");
    }

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Массив после сортировки:");

BubbleSort(array);
Console.WriteLine();

int Calculations(int[] mas)
{
    int i = 0;
    int evenNumbers = 0;
    while (i < mas.Length)
    {        
        if (mas[i] % 2 == 0)
        {
            evenNumbers++;
        }
        i++;
    }
    return evenNumbers;
}

Console.WriteLine();
Console.WriteLine("Количество чётных чисел: " + Calculations(array));
Console.WriteLine();
Console.WriteLine();


