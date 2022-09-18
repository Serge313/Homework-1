int number = GetNumber("Enter your number ");
PrintEvenNumbers(number);


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintEvenNumbers(int a)
{
    int startNumber = 2;
    while (startNumber <= a)
    {
        Console.Write($"{startNumber} ");
        startNumber = startNumber + 2;
    }
}