
// =========================================================================================
// №52 Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
// =========================================================================================

Console.Clear();

double[,] array = FillTwoDimArray(5, 4); // размер массива (строки, столбцы)

Console.WriteLine();
PrintTwoDimArray(array);
Console.WriteLine("------------------------------");
PrintOneDimArray(CalculateSum(array));
Console.WriteLine("------------------------------");
PrintOneDimArray(Count(CalculateSum(array)));

// метод для вычисления суммы в столбцах массива и на выходе массив с суммами
double[] CalculateSum(double[,] arr)
{
    double[] result = new double[arr.GetLength(1)];

    int j = 0; int i = 0;

    while (i < arr.GetLength(0))
    {
        j = 0;
        while (j < arr.GetLength(1))
        {
            result[j] += arr[i, j];
            j++;
        }
        i++;
    }

    return result;
}

// метод вычисляем среднее арифметическое
double[] Count(double[] arr)
{    
    int i = 0;
    while (i < arr.Length)
    {   
        arr[i] = Math.Round(arr[i] / array.GetLength(0),2);
        i++;
    }
    return arr;
}

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
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

//метод для печати двумерного массива 
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

//Метод печатает массив одномерный 
void PrintOneDimArray(double[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + "\t");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}