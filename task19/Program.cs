﻿

Console.Clear();

Console.Write("Введите четырёхзначное число: ");
string? inputLine = Console.ReadLine();

char[] arr = inputLine.ToString().ToCharArray();
if (arr.Length < 4 || arr.Length > 4)
{
    Console.Write("Я же просил ЧЕТЫРЁХзначное!");
}
else if (inputLine != null)
{
    if (arr[3] == arr[0] && arr[2] == arr[1])
    {
        Console.Write("Палиндром!");
    }
    else {
        Console.Write("НЕ палиндром!");
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
   
   /*
    var palindromes = new Dictionary<int, string>()
    {

    };
*/
}