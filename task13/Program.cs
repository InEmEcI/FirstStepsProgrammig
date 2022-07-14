//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
string? inputLine = Console.ReadLine();

void secondDigitOfTheNumber()
{
if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 100 || inputNumber > 999) // является ли введённое число трёхзначным ?
        {
            Console.Write("Ошибка ввода!");
        } else 
        {
            string stringNumber = inputNumber.ToString();
            char[] arr = stringNumber.ToCharArray();
            Console.Write("Вторая цифра = ");    
            Console.Write(arr[1]);
        }
}   
}
secondDigitOfTheNumber();


