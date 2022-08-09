
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
//
// * Найдите все пары в массиве и выведите пользователю

Console.Clear();

int[] array = FillingArray(-100, 100, 1000);

PrintIntArray(array);

Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(ElementsSum(array));
Console.WriteLine("Пары элементов в массиве: ");
SearchPairs(array);

//Метод возвращает одномерный массив, заполненный случайными числами от A до B. C - размер массива. 
int[] FillingArray(int a, int b, int c)
{
    int[] outArray = new int[c];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < c)
    {
        outArray[i] = numberSintezator.Next(a, b);
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    Console.Write("[ ");
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + "  ");
        //Увеличиваем инкремент
        i++;
    }
    Console.WriteLine(inputArray[i] + " ]");    
}

// Метод выводит сумму элементов, стоящих на нечётных позициях
int ElementsSum(int [] arr)

{
    int i = 1;
    int sum = 0;
    while (i < arr.Length)
    {
        sum = sum + arr[i];       
        i = i + 2;
    }
    return sum;
}

// метод ищет все пары в массиве и выводит их на печать
void SearchPairs(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] == arr[i+1])
        {
            Console.Write(arr[i] + " ");
            Console.WriteLine(arr[i+1]);
        }
    }
}

