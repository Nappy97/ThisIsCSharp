class MyClass
{
    static void Main(string[] args)
    {
        int i = 10;
        const int a = 10;

        Console.WriteLine($"{i + 1}");

        i = a;
        Console.WriteLine($"{i++}");

        i = a;
        Console.WriteLine($"{++i}");

        i = a;
        Console.WriteLine($"{i += 1}");

        i = 0xF0 | 0x0F;
        Console.WriteLine($"{i}");
        Console.WriteLine(i);

        string b = a == 0 ? "가나다" : "ABC";
        Console.WriteLine(b);
    }
}