

// Задача №38 

// 1) Задайте массив вещественных чисел 
// 2) Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// 3) * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

Console.Clear();

int[] array = FillingArray(-100, 100);

PrintArray(array);
Console.WriteLine("------------------------------------------------");
MaxMinDifference(array);

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Массив, отсортированный методом Вставки: ");
DateTime timePoint = DateTime.Now;
PrintArray(InsertsMetod(array));
Console.WriteLine("Время cортировки: " + (DateTime.Now - timePoint));
Console.WriteLine("------------------------------------------------");

//Метод печатает массив
void PrintArray(int[] arr)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    Console.Write("[ ");
    while (i < arr.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(arr[i] + "  ");
        //Увеличиваем инкремент
        i++;
    }
    Console.WriteLine(arr[i] + " ]");
}

// метод определяет минимальный и максимальный элемент массива и разницу между ними
void MaxMinDifference(int[] arr)
{
    Console.WriteLine("минимальное число: " + arr.Min());
    Console.WriteLine("максимальное число: " + arr.Max());
    Console.Write("Разница между ними: ");
    Console.WriteLine(arr.Max() - arr.Min());
}

// выдаёт массив, отсортированный методом Вставки
int[] InsertsMetod(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int cur = arr[i];
        int j = i;
        while (j > 0 && cur < arr[j - 1])
        {
            arr[j] = arr[j - 1];
            j--;
        }
        arr[j] = cur;
    }


    // for (int i = 0; index < arr.Length; index++)
    // {
    //     index = i;
    //     currentNumber = arr[i];
    //     while (index > 0 && currentNumber < arr[index - 1])
    //     {
    //         index--;
    //     }
    //     arr[index] = currentNumber;
    // }
    return arr;
}


// сортироква массива методом Подсчета

DateTime timePoint1 = DateTime.Now;
int[] sortedArray = CountingSort(array);
Console.WriteLine("Массив, отсортированный методом Подсчёта: ");
Console.Write("[ ");
for (int i = 0; i < sortedArray.Length; i++)
    Console.Write(sortedArray[i] + "  ");
Console.WriteLine("]");
Console.WriteLine("Время cортировки: " + (DateTime.Now - timePoint1));
Console.WriteLine("------------------------------------------------"); 

int[] CountingSort(int[] array)
{
    int[] sortedArray = new int[array.Length];
 
    // find smallest and largest value
    int minVal = array[0];
    int maxVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minVal) minVal = array[i];
        else if (array[i] > maxVal) maxVal = array[i];
    }
 
    // init array of frequencies
    int[] counts = new int[maxVal - minVal + 1];
 
    // init the frequencies
    for (int i = 0; i < array.Length; i++)
    {
        counts[array[i] - minVal]++;
    }
 
    // recalculate
    counts[0]--;
    for (int i = 1; i < counts.Length; i++)
    {
        counts[i] = counts[i] + counts[i - 1];
    }
 
    // Sort the array
    for (int i = array.Length - 1; i >= 0; i--)
    {
        sortedArray[counts[array[i] - minVal]--] = array[i];
    }
 
    return sortedArray;
}


//Метод возвращает одномерный массив, заполненный случайными ЦЕЛЫМИ числами от A до B
int[] FillingArray(int a, int b)
{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10) // длинна массива
    {
        outArray[i] = numberSintezator.Next(a, b);
        i++;
    }
    return outArray;
}

/*
//Метод возвращает одномерный массив, заполненный случайными ВЕЩЕСТВЕННЫМИ числами от A до B
double[] FillingArray(int a, int b)
{
    double[] outArray = new double[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10) // длинна массива
    {
        outArray[i] = numberSintezator.NextDouble() * 100;
        // * (b - a) + a;
        i++;
    }
    return outArray;
}
*/
