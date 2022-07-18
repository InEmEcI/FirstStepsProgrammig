
Console.Clear();
//string? inputlineN = Console.ReadLine();

/*
if (inputlineN != null)
{
    int inputNumberN = int.Parse(inputlineN);

    //string LineN = "";
    string LineN = string.Empty;
    int s = 1;
    while(s <= numberN)
    { 
        LineN=LineN+s+ "";
        lineNN = LineNN + (s*s).ToString() + "";
        s++;
    }


    Console.WriteLine(LineN);
    Console.WriteLine(LineNN);

}

*/


/*
//Версия Кирилла
List<int> listGen(int number) {
    List<int> numbers = new List<int>();
    for(int i = 1; i <= number; i++){
        numbers.Add(i);
    }
    return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums) {
        Console.Write(i);
        Console.Write(" ");
    }  
    Console.WriteLine();
    foreach (var i in nums) {
        Console.Write(Math.Pow(i, 2));
        Console.Write(" ");
    }
}

*/


List<int> listGen(int number) {
    List<int> numbers = new List<int>();
    for(int i = 1; i <= number; i++){
        numbers.Add(i);
    }
    return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums)
     {
        //Console.WriteLine("_");
        Console.Write("|");
        Console.WriteLine(i);
        Console.Write("|");
    }  
    Console.WriteLine();
    foreach (var i in nums) {
        Console.Write(Math.Pow(i, 2));
        Console.Write("_");
    }
