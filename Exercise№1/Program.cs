int a = GetNumber("Enter your first number ");
int b = GetNumber("Enter your second number ");
WhichIsBigger(a, b);

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WhichIsBigger(int a, int b)
{
    int max = 0;
    int min = 0;
    if (a > b)
    {
        max = a;
        min = b;
        Console.WriteLine($"a = {a}; b = {b} -> max = {max}, min = {min}");
    }
    else if (a < b)
    {
        max = b;
        min = a;
        Console.WriteLine($"a = {a}; b = {b} -> max = {max}, min = {min}");
    }
    else
    {
        Console.WriteLine("a = b");
    }
}