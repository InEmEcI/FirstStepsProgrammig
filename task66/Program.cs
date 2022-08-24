// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int m = ReadData("Введите M: "); 
int n = ReadData("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

СountingElementsSum(m, n, temp = 0);

/* ------------------------------------------- */

// СountingElementsSum
void СountingElementsSum(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write("Сумма элементов от M до N: " + summ);
        return;
    }
    СountingElementsSum(m, n - 1, summ);
}

// метод получения данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "");
}
