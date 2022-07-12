// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.Clear();
Console.Write("Введите число (от 1 ...): ");

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 1) {
       Console.Write("Ошибка ввода!"); 
    } else {
        int B = 2;
        string line = "";
        while (B < inputNumber){
            line = line + B + ", ";
            B = B + 2;
        }
        Console.WriteLine("Все чётные от 1 до " + inputNumber + ":");
        Console.WriteLine(line);
    }

}