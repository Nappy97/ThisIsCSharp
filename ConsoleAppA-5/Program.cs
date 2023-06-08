namespace ConsoleAppA_5;

class MyClass
{
    static void Main(string[] args)
    {
        var fmt = "{0,-20}{1,-15}{2,30}";

        Console.WriteLine(fmt, "Publisher", "Author", "Title");
        Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
        Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
        Console.WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
    }
}