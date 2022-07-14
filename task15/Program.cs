// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели: ");
string? inputLine = Console.ReadLine();
void numberOfWeek()
{
if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 1 || inputNumber > 7) 
        {
            Console.Write("Такого дня не существует!");
        } else if (inputNumber == 6 || inputNumber == 7)
            Console.Write("Это выходной!!! :-)");
                else {
                         Console.Write("Это рабочий день... :-(");
                     }     
}
}
numberOfWeek();