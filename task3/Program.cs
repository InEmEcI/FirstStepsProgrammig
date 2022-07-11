

Console.Write("Введите число: ");

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{

    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber * -1;

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput + startNumber + ", ";
        startNumber++;
    }
    lineOutput = lineOutput + inputNumber;
    Console.Write(lineOutput);
};