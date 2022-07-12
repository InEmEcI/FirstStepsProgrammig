
Console.Clear();
Console.Write("Ваедите число: ");


string? inputLine = Console.ReadLine();

if (inputLine != null) {
    char[] M = inputLine.ToCharArray();
    Console.Write(M[2]);
}

/*
    if (inputLine != null) {
    int inputNumber = int.Parse(inputLine);
    int outputNumber = inputNumber%10;
    Console.Write("Остаток от деления на 10 = ");
    Console.Write(outputNumber);
}
*/


/*
if (inputLine != null) {
    int inputNumber = int.Parse(inputLine);
    int outputNumber = inputNumber%10;
    Console.Write("Остаток от деления на 10 = ");
    Console.Write(outputNumber);
}
*/



