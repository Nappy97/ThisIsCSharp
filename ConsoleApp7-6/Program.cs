class MyClass
{
    private int a, b, c;

    public MyClass()
    {
        this.a = 5425;
        Console.WriteLine("MyClass()");
    }

    public MyClass(int b) : this()
    {
        this.b = b;
        Console.WriteLine($"MyClass({b})");
    }

    public MyClass(int b, int c) : this()
    {
        this.c = c;
        Console.WriteLine($"MyClass({b}, {c})");
    }

    public void PrintFields()
    {
        Console.WriteLine($"a:{a}, b:{b}, c:{c}");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var a = new MyClass();
        a.PrintFields();
        Console.WriteLine();

        var b = new MyClass(1);
        b.PrintFields();
        Console.WriteLine();

        var c = new MyClass(10, 20);
        c.PrintFields();
        Console.WriteLine();
    }
}

