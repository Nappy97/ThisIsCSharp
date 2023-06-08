class MyClass
{
    static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }

    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;

        Console.WriteLine($"x:{x}, y:{y}");
        
        Swap(ref x, ref y);
        
        Console.WriteLine($"x:{x}, y:{y}");
    }
}