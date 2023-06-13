namespace ConsoleApp16_4;

class MyClass
{
    [Obsolete("Old Method는 폐기되었습니다. NewMethod()를 이용하세요.")]
    public void OldMethod()
    {
        Console.WriteLine("I'm old");
    }

    public void NewMethod()
    {
        Console.WriteLine("I'm new");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var obj = new MyClass();

        obj.OldMethod();
        obj.NewMethod();
    }
}