
Console.Clear();
Console.Write("Ваедите число: ");


string? inputLine = Console.ReadLine();

if (inputLine != null) {
    int inputNumber = int.Parse(inputLine);
    int outputNumber = inputNumber%10;
    Console.Write("Остаток от деления на 10 = ");
    Console.Write(outputNumber);
}

