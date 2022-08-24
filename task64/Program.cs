// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Clear(); 

int num1 = ReadData("Введите число M: ");
int num2 = ReadData("Введите число N: ");

if (num1 < num2) 
{
    Console.Write("Все натуральные числа в промежутке от M до N: ");
    SortInAscendingOrder(num1,num2);    
}
else
{
    Console.Write("Все натуральные числа в промежутке от M до N: ");    
    SortInDescendingOrder(num2,num1);            
}

/* -------------------------------------------------------------- */

// метод получения данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "");
}

// метод вывода на экран по возрастанию
void SortInAscendingOrder(int m, int n)
{    
    if (m - 1 == n) return;
    Console.Write(m + " "); 
    SortInAscendingOrder(m + 1, n); 
}

// метод вывода на экран по убыванию
void SortInDescendingOrder(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(n + " ");
    SortInDescendingOrder(m, n - 1);
}