// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// В 13 задачи оперировать с числом, а не строкой.


Console.Clear();

void thirdDigitVariant1()
{    
Console.WriteLine("--------------------");
Console.WriteLine("Вариант 1");
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

{
if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 100) // проверяет есть ли у числа третья цифра
        {
            Console.WriteLine("Третьей цифры нет");
            Console.WriteLine("--------------------");
        } else 
        {
            string stringNumber = inputNumber.ToString();
            char[] arr = stringNumber.ToCharArray();
            Console.Write("Третья цифра = ");    
            Console.WriteLine(arr[2]);
            Console.WriteLine("--------------------");                     
        }
}
}
}







void thirdDigitVariant2()
{
Console.WriteLine("Вариант 2");
Console.Write("Введите число: ");
string? inputLine1 = Console.ReadLine();

{
if (inputLine1 != null) 
{
    int inputNumber = int.Parse(inputLine1);
    if (inputNumber < 100) // проверяет есть ли у числа третья цифра
        {
            Console.WriteLine("Третьей цифры нет");
            Console.WriteLine("--------------------");
        } else 
        {        
         int thirdТumber = inputNumber % 10; // вычисляет третью цифру введённого числа        
         Console.Write("Третья цифры: ");
         Console.WriteLine(thirdТumber);
         Console.WriteLine("--------------------");
        }
}
}
}


thirdDigitVariant1();
thirdDigitVariant2();