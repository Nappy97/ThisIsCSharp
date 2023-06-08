class Calcultor
{
    public static int Plus(int a, int b)
    {
        return a + b;
    }

    public static int Minus(int a, int b)
    {
        return a - b;
    }
}

class MainApp
{
    public static void Main(string[] args)
    {
        var result = Calcultor.Plus(3, 4);
        Console.WriteLine(result);

        result = Calcultor.Minus(5, 2);
        Console.WriteLine(result);
    }
}