// =========================================================================================
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)
// =========================================================================================

Console.Clear();

FillAndPrintThreeDimArray();


/* ------------------------------------------------------------------ */

// метод построчно выводить массив, добавляя индексы каждого элемента
void FillAndPrintThreeDimArray()
{
    Console.Write("Введите первую цифру: ");
    int one = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите вторую цифру: ");
    int two = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите третью цифру: ");
    int three = int.Parse(Console.ReadLine() ?? "");

int[,,] threeDimDrray = new int[one, two, three];

List<int> list = new List<int>();

    int i = 0; int j = 0; int k = 0;
    while (i < threeDimDrray.GetLength(0))
    {
        while (j < threeDimDrray.GetLength(1))
        {
            while (k < threeDimDrray.GetLength(2))
            {
                int randomNumber = new Random().Next(10, 100);
                if (!(list.Contains(randomNumber)))
                {
                    threeDimDrray[i, j, k] = randomNumber;
                    list.Add(randomNumber);
                    Console.WriteLine(threeDimDrray[i, j, k] + "(" + i + "," + j + "," + k + ")");                    
                }
                else k++;
            }
            j++;
        }
        i++;
    }

}

/* ------------------------------------------------------------------ */

