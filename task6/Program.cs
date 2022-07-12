
// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


Console.Clear();
Console.Write("Введите первое число: ");
string? inputLine1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLine2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? inputLine3 = Console.ReadLine();

if (inputLine1 != null && inputLine2 != null && inputLine3 != null) {
    int A = int.Parse(inputLine1);
    int B = int.Parse(inputLine2);
    int C = int.Parse(inputLine3);

if (A > B) { // A > B
  if (A > C) {
     Console.Write(A);
    } 
} else // A < B
        {
          if (C > B) {
            Console.Write("Самое большое из них = ");
            Console.Write(C);
          } else {
            Console.Write("Самое большое из них = ");
            Console.Write(B);
          }    
        } 
}

// ИНВАРИАНТ
/*    
    else if (A > B && A > C) {
        Console.Write("Первое число больше");
    } else if (B > A && B > C) {
        Console.Write("Второе число больше");
    } else if (C > A && C > B) {
        Console.Write("Третье число больше");
    }
*/    