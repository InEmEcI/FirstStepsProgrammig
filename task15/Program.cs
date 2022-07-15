// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.



// В 15 задаче использовать конструкции: 
// * List<>  -
// * Dictionary<>  + 
// 2 варианта решения соответственно.

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
/*void numberOfWeek_Dictionary()
{
if (inputLine != null) 
{       
    int inputNumber = int.Parse(inputLine);
    Dictionary<int, string> week = new Dictionary<int, string>()    
        {
        [1] = "Понедельник. Рабочий день.",
        [2] = "Вторник. Рабочий день.",
        [3] = "Среда. Рабочий день.",
        [4] = "Четверг. Рабочий день.",
        [5] = "Пятница. Рабочий день.",    
        [6] = "Суббота. Выходной день!",
        [7] = "Воскресенье.Выходной день!"
        };
Console.Write(week.GetValueOrDefault(inputNumber));
};
}       
*/

// Вариант 3

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    
    var week = new Dictionary<int, string>() 
{
        [1] = "Понедельник. Рабочий день.",
        [2] = "Вторник. Рабочий день.",
        [3] = "Среда. Рабочий день.",
        [4] = "Четверг. Рабочий день.",
        [5] = "Пятница. Рабочий день.",    
        [6] = "Суббота. Выходной день!",
        [7] = "Воскресенье.Выходной день!"
};
    Console.WriteLine($"Это: {week[inputNumber]}");    
}



//numberOfWeek_1();
//numberOfWeek_Dictionary();
//numberOfWeek_List();
