
/*

№23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
чисел от 1 до N.1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
* Вывести таблицу с границами и значениями друг над другом

*/



Console.Clear();
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
//int count = 0; // для чётчика


// Console.Clear();

// Console.Write("Введите число: ");

// List<int> listGen(int number)
// {
//     List<int> numbers = new List<int>();
//     for (int i = 1; i <= number; i++)
//     {
//         numbers.Add(i);
//     }
//     return numbers;
// }

if (inputLine != null)
{

    int inputNumber = int.Parse(inputLine);
    for (int i = 0; i < inputNumber; i++)
    {
        Console.Write("|");
        Console.Write(inputNumber);
        Console.WriteLine("|");
        Console.WriteLine();
        Console.Write("|");
        Console.Write(Math.Pow(inputNumber, 3));
        inputNumber++;
        Console.WriteLine("|");
    }

}



// int count;

// int inputNumber = int.Parse(inputLine);
// count = inputNumber;

// while (count < inputNumber)
// {
//     Console.Write("|");
//     Console.Write(inputNumber);
//     Console.WriteLine("|");


//     Console.WriteLine();

//     Console.Write("|");
//     Console.Write(Math.Pow(inputNumber, 3));
//     Console.WriteLine("|");
//     inputNumber++;
//     count--;

// }

/*
if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums) {
        Console.Write("|");
        Console.Write(i);
        Console.WriteLine("|");
    }  
    Console.WriteLine();
    foreach (var i in nums) {
        Console.Write("|");
        Console.Write(Math.Pow(i, 3));
        Console.WriteLine("|");
    }
}

*/



// вариант для таблици кубы СПРАВА от цифры
/*
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums)
    {
        Console.WriteLine("___");
        Console.Write("|");
        Console.Write(i);
        Console.Write("|"); Console.Write(Math.Pow(i, 3));Console.WriteLine("|");
        Console.Write("___");
        //Console.Write("|");
    }
  */






/*

if (inputLine != null)
{

    int inputNumber = int.Parse(inputLine);


    for (; count < inputNumber; count++)
    {
        Console.WriteLine("___");
        Console.Write("|");
        Console.Write(inputNumber);
        Console.WriteLine("|");
        Console.Write("___");

        Console.WriteLine("___");
        Console.Write("|");
        Console.Write(Math.Pow(inputNumber, 3));
        Console.WriteLine("|");
        Console.Write("___");
    };
}

*/








/*
  
    Console.WriteLine();
    foreach (var i in nums)
    {
        Console.WriteLine("___");
        Console.Write("|");
        Console.Write(Math.Pow(i, 3));
        Console.WriteLine("|");
        Console.WriteLine("___");
        
        Console.Write("___");
        Console.Write("|");
        Console.Write(Math.Pow(i, 3));
        Console.WriteLine("|");
        
    }


*/

