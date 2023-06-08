class MyClass
{
    public static void Swap(int a, int b)
    {
        var temp = b;
        b = a;
        a = temp;
        // (b, a) = (a, b);
    }

    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;

        Console.WriteLine($"x : {x}, y : {y}");

        Swap(x, y);
        
        Console.WriteLine($"x : {x}, y : {y}");

    }
}