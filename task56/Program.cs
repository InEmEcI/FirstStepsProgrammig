
<<<<<<< HEAD

=======
>>>>>>> 08ac24c6833e6f6fd7afecc0a207aada827cbea5
// // // =========================================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// // // =========================================================================================

Console.Clear();



int[,] array = FillTwoDimArray(4, 4);
PrintTwoDimArray(array);
Console.WriteLine();
Console.Write("Номер строки с наименьшей суммой элементов: " + FindRow(array));
Console.WriteLine(); Console.WriteLine();

/* ------------------------------------------------------------------ */

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
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArray;
}

// метод для печати двумерного int массива 
void PrintTwoDimArray(int[,] arr)
{
    int i = 0; int j = 0;

    while (i < arr.GetLength(0))
    {
        j = 0;
        while (j < arr.GetLength(1))
        {
            Console.Write(arr[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// метот выдаёт индекс наименьшего элемента
int FindMinIndex(int[] arr)
{
    int index = 0; int min = arr[0]; int i = 0;

    while (i < arr.Length)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
        i++;
    }
    return index;
}

// метод считает сумму элементов в строке 
int SummRows(int[,] arr, int row)
{
    int i = 0; int sum = 0;
    while (i < arr.GetLength(1))
    {
        sum += arr[row, i];
        i++;
    }
    return sum;
}

// метод выдаёт номер строки с наименьшей суммой элементов
int FindRow(int[,] arr)
{
    int i = 0;
    int[] sum = new int[arr.GetLength(0)];
    while (i < arr.GetLength(0))
    {
        sum[i] = SummRows(arr, i);
        i++;
    }
    return FindMinIndex(sum) + 1;
}
