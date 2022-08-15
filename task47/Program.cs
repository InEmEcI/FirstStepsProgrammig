
// =========================================================================================
// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)                                        
// =========================================================================================

Console.Clear();

// 15 цветов консоли из 16 (не считая чёрного) 
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

double[,] array = FillTwoDimArray(3, 4); // размер массива

// PrintTwoDimArray(array);

Console.WriteLine();

// PrintColorTwoDimArray();
 PrintColorTwoDimArray(array);

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
            // outArray[i, j] = numberSyntezator.NextDouble();
            double var = numberSyntezator.NextDouble() * 100;
            outArray[i, j] = Math.Round(var, 2);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива (белым цветом)
void PrintTwoDimArray(double[,] inputArray)
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

// метод для печати двумерного массива из вещественных чисел рандомными цветами
void PrintColorTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 15)];
            Console.Write(inputArray[i, j] + "\t");
            // Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

