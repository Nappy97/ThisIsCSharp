class MyClass
{
    static void Main(string[] args)
    {
        object obj = null;

        var s = Console.ReadLine();
        if (int.TryParse(s, out var out_i))
            obj = out_i;
        else if (float.TryParse(s, out var out_f))
            obj = out_f;
        else
            obj = s;

        switch (obj)
        {
            case int i :
                Console.WriteLine($"{i}는 int 형식");
                break;
            case float f:
                Console.WriteLine($"{f}는 float 형식");
                break;
            default:
                Console.WriteLine($"{obj}는 모르는 형식");
                break;
        }
    }
}