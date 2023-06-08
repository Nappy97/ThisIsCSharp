class MyClass
{
    static void Main(string[] args)
    {
        var a = 9;
        var b = 10;

        Console.WriteLine($"{a} & {b} : {a & b}");
        Console.WriteLine($"{a} | {b} : {a | b}");
        Console.WriteLine($"{a} ^ {b} : {a ^ b}");

        int c = 255;
        Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);
    }
}