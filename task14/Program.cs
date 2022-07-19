// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// В 13 задачи оперировать с числом, а не строкой.


Console.Clear();
/*
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
            }
            else
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
*/

/*
void thirdDigitVariant2()
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Вариант 2");
    Console.Write("Введите число: ");
    string? inputLine2 = Console.ReadLine();

    else
    {

        if (inputLine2 != null)
        {

            int inputNumber = int.Parse(inputLine2);
            if (inputNumber < 100) // проверяет есть ли у числа третья цифра
            {
                Console.WriteLine("Третьей цифры нет");
                Console.WriteLine("--------------------");
            }
            else
            {
                double value = (inputNumber / 10) % 10;
                Console.WriteLine(value);
            }
            //int thirdТumber = inputNumber % 10;
            //может цикл ? 
            
            int thirdТumber = inputNumber % 10; // вычисляет третью цифру введённого числа        
            Console.Write("Третья цифры: ");
            Console.WriteLine(thirdТumber);
            Console.WriteLine("--------------------");
            


Console.WriteLine("Вариант 2");
Console.Write("Введите число: ");
string? inputLine2 = Console.ReadLine();



    }
}
*/



void variant3()
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Вариант 3");
    Console.Write("Введите число: ");
    string? inputLine3 = Console.ReadLine();


    if (inputLine3 != null)
    {
        // проверка на ввод числа начинающегося на 0
        //int inputNumber2 = int.Parse(inputLine2);
        char[] arr3 = inputLine3.ToString().ToCharArray();
        //string stringNumber2 = inputNumber2.ToString();
        Console.WriteLine(arr3);
        
        if (arr3[0] == '0')
        {
            //Console.Write("Число не должно начинаться на 0!");
            Console.WriteLine("Число начинается на 0!");
        }
        else
        {
            Console.WriteLine("Число начинается НЕ на 0!");
        }
    }
}





//thirdDigitVariant1();
//thirdDigitVariant2();
variant3();