// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.


// В 15 задаче использовать конструкции List<> и Dictionary<> 2 варианта решения соответственно.

Console.Clear();
Console.Write("Введите номер дня недели: ");
string? inputLine = Console.ReadLine();

// Вариант 1
/*
void numberOfWeek_1()
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
*/

// Вариант 2
void numberOfWeek_2()
{
    if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);

    Dictionary<int, string> week = new Dictionary<int, string>()
    {
        {1, "рабочий" },
        {2, "рабочий" },
        {3, "рабочий" },
        {4, "рабочий" },
        {5, "рабочий" },
        {6, "Выходной" },
        {7, "Выходной" },        
    };
}
    Console.WriteLine({week.FirstOrDefault(x => x.Key == inputNumber).Value});
};

//numberOfWeek_1();

numberOfWeek_2();