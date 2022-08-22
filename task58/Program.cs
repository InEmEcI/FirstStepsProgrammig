// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

int[,] array1 = FillTwoDimArray(4, 4);
int[,] array2 = FillTwoDimArray(4, 4);
Console.WriteLine("--------------------------");
PrintTwoDimArray(array1);
Console.WriteLine("--------------------------");
PrintTwoDimArray(array2);
Console.WriteLine("--------------------------");
// Console.WriteLine(); Console.WriteLine();
PrintTwoDimArray(MultiplyingTwoDimArray(array1, array2));
Console.WriteLine("--------------------------");


/* ------------------------------------------------------------------ */

// метод для перемножения двух двумерных int массивов
int[,] MultiplyingTwoDimArray(int[,] arr1, int[,] arr2)
{
    int[,] temp = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            temp[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return temp;
}
Console.WriteLine();

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