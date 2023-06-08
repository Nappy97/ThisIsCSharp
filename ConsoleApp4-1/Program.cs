namespace ConsoleApp4_1;

class MyClass
{
    static void Main(string[] args)
    {
        var a = 111 + 222;
        Console.WriteLine($"a : {a}");

        var b = a - 100;
        Console.WriteLine($"b : {b}");

        var c = b + 10;
        Console.WriteLine($"c : {c}");

        var d = c / 6.3;
        Console.WriteLine($"d : {d}");

        Console.WriteLine($"22/7 = {22 / 7}({22 % 7})");
    }
}