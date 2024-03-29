﻿
// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

Console.Clear();

//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[20];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 20)
    {
        outArray[i] = numberSintezator.Next(-100,100);
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
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

object[] CopyArrayStandartTool(params object[] inputArray)
{
    object[] buferArray = new object[inputArray.Length];
    inputArray.CopyTo(buferArray,0);
    return buferArray;
}

int[] testArray = FillingArray();
PrintIntArray(testArray);

// int[] outArray = (int[])CopyArrayStandartTool(testArray);
// PrintIntArray(outArray);