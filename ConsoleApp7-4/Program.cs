class MyClass
{
    public int MyField1;
    public int MyField2;

    public MyClass DeepCopy()
    {
        var newCopy = new MyClass();
        newCopy.MyField1 = this.MyField1;
        newCopy.MyField2 = this.MyField2;

        return newCopy;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shallow Copy");
        {
            var source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            var target = source;
            target.MyField2 = 30;

            Console.WriteLine($"{source.MyField1} : {source.MyField2}");
            Console.WriteLine($"{target.MyField1} : {target.MyField2}");
        }

        Console.WriteLine("Deep Copy");
        {
            var source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            var target = source.DeepCopy();
            target.MyField2 = 30;

            Console.WriteLine($"{source.MyField1} {source.MyField2}");
            Console.WriteLine($"{target.MyField1} {target.MyField2}");
        }
    }
}