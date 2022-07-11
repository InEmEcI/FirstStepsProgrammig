
Console.Clear();
Console.Write("Ваедите число: ");


string? inputLine = Console.ReadLine();

if (inputLine != null) {
    int inputNumber = int.Parse(inputLine);
    int outputNumber = (int)Math.Pow(inputNumber,2);
    Console.Write("В квадрате оно = ");
    Console.Write(outputNumber);
}

