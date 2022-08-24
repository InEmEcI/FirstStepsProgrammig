
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

int inputM = ReadData("Задайте число M (положительное): "); 
int inputN = ReadData("Задайте число N (положительное): "); 

Console.WriteLine($"A({inputM},{inputN}) = {FunctionAckerman(inputN, inputM)}"); 

/* ----------------------------------------------- */

// функция Аккермана 
int FunctionAckerman(int n, int m) 
{ 
    if (n == 0) 
        return m + 1; 
    else 
      if ((n != 0) && (m == 0)) 
        return FunctionAckerman(n - 1, 1); 
    else 
        return FunctionAckerman(n - 1, FunctionAckerman(n, m - 1)); 
}


// метод получения данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "");
}