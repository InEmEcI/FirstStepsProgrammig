﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// В 13 задачи оперировать с числом, а не строкой.

Console.Clear();
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

void thirdDigitVariant1()
{
if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 100) // проверяет есть ли у числа третья цифра
        {
            Console.Write("Третьей цифры нет");
        } else 
        {
            string stringNumber = inputNumber.ToString();
            char[] arr = stringNumber.ToCharArray();
            Console.Write("Третья цифра = ");    
            Console.Write(arr[2]);           
        }
}
}

thirdDigitVariant1();