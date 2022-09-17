int number = GetNumber("Enter your number ");
EvenOrNot(number);


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void EvenOrNot(int a)
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a} -> да");
    }
    else
    {
        Console.WriteLine($"{a} -> нет");
    }
}