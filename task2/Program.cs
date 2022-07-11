

Console.Clear();
Console.Write("Введите номер дня недели: ");

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);

    switch(inputNumber)
    {
        case 1:
        Console.Write("Это Понедельник");
        break;

        case 2:
        Console.Write("Это Вторник");         
        break;

        case 3:
        Console.Write("Это  Среда");         
        break;

        case 4:
        Console.Write("Это Четверг");         
        break;

        case 5:
        Console.Write("Это Пятница");
        break;

        case 6:
        Console.Write("Это Суббота");         
        break;

        case 7:
        Console.Write("Это Воскресенье");         
        break;
    }

    /*
    string [] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

    Console.Write("Это "); 
    Console.Write(dayOfWeek[inputNumber - 1]);
    */
}