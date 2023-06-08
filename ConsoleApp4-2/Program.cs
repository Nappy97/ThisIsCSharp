namespace ConsoleApp4_2;

class MyClass
{
    static void Main(string[] args)
    {
        var a = 10;
        Console.WriteLine(a++);
        Console.WriteLine(++a);

        Console.WriteLine(a--);
        Console.WriteLine(--a);
    }
}