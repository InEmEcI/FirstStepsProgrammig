// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] FillTwoDimArray(int countRow, int countColumn)
// {
//     //создаем экземпляр типа рандомайзер
//     System.Random numberSintezator = new System.Random();

//     //буфферные переменные строки и столбца
//     int i = 0; int j = 0;

//     //создаем массив
//     int[,] outArray = new int[countRow, countColumn];

//     //цикл заполнения массива сначала по столбцам, потом по строчкам
//     while (i < countRow)
//     {
//         j = 0;
//         while (j < countColumn)
//         {
//             outArray[i, j] = numberSintezator.Next(0, 10);
//             j++;
//         }

//         i++;
//     }
//     //возвращаем значение
//     return outArray;
// }
// //Метод печатает двумерныймассив
// void PrintTwoDimArray(int[,] inputArray)
// {
//     //Буфферная переменная
//     int i = 0; int j = 0;

//     //цикл заполнения массива сначала по столбцам, потом по строчкам
//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             Console.Write(inputArray[i, j] + " ");
//             j++;
//         }
//         //Выводим конец строки
//         //Console.Write("\n");
//         //или
//         Console.WriteLine();
//         i++;
//     }
// }



// int MinSumRow(int[,] inputArray)
// {
//     int minSum = Int32.MaxValue;
//     int line = 0;

//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         int sum = 0;

//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             sum += inputArray[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             line++;
//         }
//     }
//     Console.WriteLine($"Наименьшая сумма элементов в(во) {line}-й строке => {minSum}");
//     return minSum;
// }


// int[,] twoDimArray = FillTwoDimArray(4, 4);
// PrintTwoDimArray(twoDimArray);
// Console.WriteLine();
// Console.WriteLine(MinSumRow(twoDimArray));


int arrayRows = 8;
int arrayCols = 8;

try
{
    //Call array generating Method and save it to a new variable
    int[,] array = getArray(arrayRows, arrayCols);
    //Call array prining Method
    PrintArray(array, "Сгенерирован массив: ");
    //Call array rows sorting Method
    Console.Write("Cтрока с наименьшей суммой элементов(нумерация с 0): ");
    Console.WriteLine(BiggerRowBySumChecker(array));

}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates a 2D integer array 
int[,] getArray(int cols, int rows)
{
    //Create an int array variable
    int[,] array = new int[cols, rows];
    //Run thorugh all array's elements
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            //Generate number for current element
            array[i, j] = numberSintezator.Next(0, 100);
        }
    }
    return array;
}

//Prints array
void PrintArray(int[,] array, string text)
{
    Console.WriteLine(text);
    //Create a vaiable for columns numbers
    int rows = array.GetLength(0);
    //Create a vaiable for row numbers
    int cols = array.GetLength(1);
    //Run thorugh all array's elements
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            //Print curretn element
            Console.Write(array[i, j] + "\t");
        }
        //Move line
        Console.WriteLine();
    }
}

//Calculate a sum for all elements in given array
int RowSumm(int[,] array, int rowNumber)
{
    //Create a variable for sum
    int sum = 0;
    //Run through all elements it the given row
    for (int i = 0; i < array.GetLength(1); i++)
    {
        //Add current element to the sum
        sum += array[rowNumber, i];
    }
    return sum;
}

//findes the index of the smallet element in array
int smalestNumberIndex(int[] array) {
    //Crate variables for min element and its index 
    int minIndex = 0;
    int min = array[0];
    //Run through all elements it the given array
    for (int i = 0; i < array.Length; i++)
    {
        //If current element less than min then its min
        if(min > array[i]) {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int BiggerRowBySumChecker(int[,] array){
    //Create a temp array for containgn sums of all rows
    int[] sumArray = new int[array.GetLength(0)];
    //Run through all rows
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //Call row sum calculatiog Method for current row
        sumArray[i] = RowSumm(array, i);
    }
    return smalestNumberIndex(sumArray);
}