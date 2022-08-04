
// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120
// 


Console.Clear();

Console.Write("Введите число: ");
string? inpitLine = Console.ReadLine();
int inputNum = int.Parse(inpitLine?? "");

Console.WriteLine(sumNums(inputNum));
Console.WriteLine(mulRec(inputNum));

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
        // The same
        // sum = sum * i;
    }
    return sum;
}

// Рекурсия
int mulRec(int num)
{
   if (num == 1)
   {
    return 1; 
   } else return num * mulRec(num - 1);  
}






