
// =========================================================================================
// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл  //
// пользователь.                                                                          //              
// 0, 7, 8, -2, -2 -> 2                                                                   //  
// -1, -7, 567, 89, 223-> 3                                                               //  
//                                                                                        //      
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и             //  
// выдает сколько чисел больше 0 было введено.                                            //  
// =========================================================================================

Console.Clear();

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine() ?? "");

int[] Read(int m)
{
    int[] outArray = new int[m];
    int i = 0;
    while (i < m)
    {
        outArray[i] = int.Parse(Console.ReadLine() ?? "");
        i++;
    }
    return outArray;
}

int[] array = Read(m);

// Массив из введённого кол-ва чисел
PrintIntArray(array);

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

//вычисляет колличество цифр больше 0
int Calculate(int[] arr)
{
    int resultCount = 0;
    int i = 0;
    // пока i меньше длинны массива
    while (i < arr.Length)
    {   
        // если элемент > 0
        if (arr[i] > 0)
        {
            // увеличиваем кол-во на 1
            resultCount++;            
        }        
        i++;        
    }
    return resultCount;
}

Console.WriteLine();
Console.Write("Колличество введённых цифр больше 0: ");
//выводит на печать колличество цифр больше 0 в указанном массиве (array)
Console.WriteLine(Calculate(array));