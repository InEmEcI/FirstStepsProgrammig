// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.Clear();
Console.Write("Введите число: ");

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    int ostatok = inputNumber%2;
    if (ostatok == 0){
        Console.Write("Чётное!");
    } else {
        Console.Write("Не чётное!");
    }
}