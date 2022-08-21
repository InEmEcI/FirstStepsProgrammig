// =========================================================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
// =========================================================================================


Console.Clear();

int[,] array = FillTwoDimArray(3, 7);
Console.WriteLine("Массив изначальный: ");
PrintTwoDimArray(array);
Console.WriteLine();
Console.WriteLine("Массив после сортировки: ");
PrintTwoDimArray(ArraySort(array));

/* -------------------------------------------- */


// метод для заполнения двумерного int массива
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

//метод для печати двумерного int массива 
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

//Метод сортировки строки по убыванию
int[,] ArraySort(int[,] arr)
{
    int i = 0; int j = 0;
    int temp = 0;    
    while (i < arr.GetLength(0))
    {
        j = 0;
        while (j < arr.GetLength(1))
        {
            for (int f = j + 1; f < arr.GetLength(1); f++)
            {
                if (arr[i, j] < arr[i, f])
                {
                    temp = arr[i, f];
                    arr[i, f] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
            j++;
        }
        i++;
    }
    return arr;
}


