
// =========================================================================================
// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых                                           
// =========================================================================================

Console.Clear();

double x = 0;
double y = 0;

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "");

Calculate();

// метод вычисляет точку пересечения двух прямых , заданных
void Calculate()
{
    x = (b2 - b1) / (k1 - k2);

    y = (k1 * x) + b1;

    // y = k1 * ((b2 - b1) / (k1 - k2)) + b1;    
    Console.WriteLine("X =  " + x);
    Console.WriteLine("Y =  " + y);
}

