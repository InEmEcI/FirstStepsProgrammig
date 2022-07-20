
/*
№21 Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
* Сделать метод загрузки точек
*/

Console.Clear();

// зарание объявляются глобальнфе переменные!
int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengthAB;

// считывает координаты точек A и B   в 3D
void readCoordOfPoints()
{
    Console.Write("Введите координаты Х в точке А: ");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Y в точке А: ");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Z в точке А: ");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты X в точке B: ");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Y в точке B: ");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Z в точке B: ");
    coordZPointB = int.Parse(Console.ReadLine());
}

// вычисляет расстояние между точками A и B  в 3D
void calculateLengthAB_3D()
{
lengthAB = Math.Sqrt(Math.Pow(coordXPointA - coordXPointB, 2) + Math.Pow(coordYPointA - coordYPointB, 2) + Math.Pow(coordZPointB - coordZPointA, 2));
} 

readCoordOfPoints();
calculateLengthAB_3D();

Console.Write("Растояние иежду ними = ");
Console.Write(lengthAB);
