
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


Console.Clear();
Console.Write("Введите первое число: ");
string? inputLine1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLine2 = Console.ReadLine();

if (inputLine1 != null && inputLine1 != null) {
    int A = int.Parse(inputLine1);
    int B = int.Parse(inputLine2);

    if (A == B) {
        Console.Write("Они равны!!!");
    } else 
        if (A > B){
            Console.Write("Первое число больше!");
        } else {
            Console.Write("Второе число больше!");
        }
}