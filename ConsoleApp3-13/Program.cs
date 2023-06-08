namespace ConsoleApp3_13;

class MyClass
{
    static void Main(string[] args)
    {
        int? a = null;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);

        a = 3;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);
        Console.WriteLine(a.Value);
    }
}