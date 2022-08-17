

// =========================================================================================
// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет                                   
// =========================================================================================

Console.Clear();

Console.Write("Введите строку: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите столбец: ");
int row = int.Parse(Console.ReadLine());

int[,] array = FillTwoDimArray(4, 3); // размер массива

Console.WriteLine("Массив: ");
PrintTwoDimArray(array);

if (column > 4 || row > 3)
{
    Console.WriteLine("Такого числа в массиве нет  ");
}
else
{
    Console.WriteLine("Это цифра: " + array[column-1, row-1]);
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(10, 100);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива (белым цветом)
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

