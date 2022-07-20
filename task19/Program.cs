

Console.Clear();

Console.Write("Введите четырёхзначное число: ");
string? inputLine = Console.ReadLine();
char[] arr = inputLine.ToString().ToCharArray(); // - если в ручную ввёл

if (arr.Length < 4 || arr.Length > 4)
{
    Console.WriteLine("Я же просил ЧЕТЫРЁХзначное!");
}
else if (inputLine != null)
{
    if (arr[3] == arr[0] && arr[2] == arr[1])
    {
        Console.WriteLine("Палиндром!");
    }
    else
    {
        Console.WriteLine("НЕ палиндром!");
    }

}


// если последняя = первой и предпоследняя = второй, то палиндром и в словарь его!
/*
заполнять нужно будет циклом - добавлять в словарь если он палиндром

ПРОВЕРКА - циклом (каждую цифру в числе от 0 до 9)
сначала их создавать ()

0000 - ок

0110
0220
0330
0440
0550
0660
0770
0880
0990

1001 - ок

1111 - ок    

9009
9119
9229
9339
9449
9559
9669
9779
9889


2002 - ок
2112 - ок
2222 - ок
2332
2442
2552
2662
2772
2882
2992

3003 - ок
3113 - ок
3223 - ок
3333 - ок

4004
4114
4224
4334
4444

*/

// int a = 0;
// int b = 0;
// int c = 0;
// int d = 0;









// for (int x = 0; x < 9; x++) 
// {
//     for (int y = 0; y < 9; y++)
//     { 
//            Console.WriteLine($"{x}{y}{y}{x}");

//     }
// }

/*
// Объявляем массив
int[] arr = new int[9999];



for (int x = 1; x <= 9; x++)
{
arr = 
}

*/

/*
for (int x = 1; x <= 9; x++)
{
    arr[3] = x;
    arr[0] = x;
    for (int y = 0; y <= 9 && x < 9; y++)
    {
        arr[1] = y;
        arr[2] = y;

        // проверяем получился ли париндром ? если да,что вывод на экран    
        if (arr[0] == arr[3] && arr[1] == arr[2])
        {
            Console.Write(arr[0]); Console.Write(arr[1]); Console.Write(arr[2]); Console.WriteLine(arr[3]);

        }

        //Console.WriteLine($"{a}{b}{b}{a}");
    }
}

*/



/*
arr[0] = 9;
arr[1] = 9;
arr[2] = 9;
arr[3] = 9;

// цикл для создания массивов из четырёх цифр
while (arr[0] > 0 && arr[3] > 0)
{

    while (arr[1] > 0 && arr[2] > 0)
        {
            Console.Write(arr[0]); Console.Write(arr[1]); Console.Write(arr[2]); Console.WriteLine(arr[3]);
            arr[1]--;
            arr[2]--;
        }
    // проверяем получился ли париндром ? если да,что вывод на экран    
    if (arr[0] == arr[3] && arr[1] == arr[2])
    {        
        Console.Write(arr[0]); Console.Write(arr[1]); Console.Write(arr[2]); Console.WriteLine(arr[3]);
        arr[0]--;
        arr[3]--;

        
    }
}

*/


// else
// {
//     Console.Write(arr[0]); Console.Write(arr[1]); Console.Write(arr[2]); Console.WriteLine(arr[3]);
//     b++;
//     c++;        
// }

/*

    int key = 1; // ключ для добавления нового палиндрома в словарь
    var palindromes = new Dictionary<int, string>()
    { };


}
*/