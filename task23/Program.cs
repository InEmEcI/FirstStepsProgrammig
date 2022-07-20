
/*

№23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
чисел от 1 до N.1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
* Вывести таблицу с границами и значениями друг над другом

*/


Console.Clear();
Console.Write("Введите число: ");

List<int> listGen(int number) {
    List<int> numbers = new List<int>();
    for(int i = 1; i <= number; i++){
        numbers.Add(i);
    }
    return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums) {
        Console.Write("|");
        Console.Write(i);
        Console.Write("|");
    }  
    Console.WriteLine();
    foreach (var i in nums) {
        Console.Write("|");
        Console.Write(Math.Pow(i, 3));
        Console.Write("|");
    }
}