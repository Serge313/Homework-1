int a = GetNumber("Enter your first number ");
int b = GetNumber("Enter your second number ");
int c = GetNumber("Enter your third number ");
WhichIsBigger(a, b, c);

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void WhichIsBigger(int a, int b, int c)
{
    int max = 0;
    if (a > b && a > c)
    {
        max = a;
        Console.WriteLine($"{a}, {b}, {c} -> {max}");
    }
    else if (b > a && b > c)
    {
        max = b;
        Console.WriteLine($"{a}, {b}, {c} -> {max}");
    }
    else if (c > a && c > b)
    {
        max = c;
        Console.WriteLine($"{a}, {b}, {c} -> {max}");
    }
    else
    {
        Console.WriteLine("a = b = c");
    }
}