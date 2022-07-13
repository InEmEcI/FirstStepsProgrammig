
Console.Clear();
Console.WriteLine("-----------------------------");
Console.WriteLine("Вариант 1");
System.Random numberSintezator = new Random();
int number = numberSintezator.Next(10,100);

Console.WriteLine(number);

int firstNumber = number / 10;
int secondNumber = number%10;

// Вариант 1
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);    
} else 
{
    Console.WriteLine(secondNumber);
}
 
// Вариант 2
Console.WriteLine("-----------------------------");
Console.WriteLine("Вариант 2");
int numberKirilla = new Random().Next(10, 100);
Console.Write("The random number is: ");
Console.WriteLine(numberKirilla);
string stringNum = numberKirilla.ToString();
Console.Write("The biggest digit is: ");
if (stringNum[0] > stringNum[1]){
    Console.WriteLine(stringNum[0]);
} else {
    Console.WriteLine(stringNum[1]);
}

// Вариант 3
Console.WriteLine("-----------------------------");
Console.WriteLine("Вариант 3");
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

Console.Write("Рандомное число: "); Console.WriteLine(digits); 

firstNumber = ((int)digits[0]-48);
secondNumber = ((int)digits[1]-48); 

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.Write("бОльшее из его цифр: "); Console.WriteLine(resultNumber);
Console.WriteLine("-----------------------------");