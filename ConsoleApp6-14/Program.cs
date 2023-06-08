// 3 + 4 = 7
// 2.4 + 3.1 = 5.5

using System.Numerics;

class MainApp
{
    public static void Main(string[] args)
    {
        var a = 3;
        var b = 4;
        var resultA = 0;

        Plus(a, b, out resultA);

        Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

        var x = 2.4;
        var y = 3.1;
        double resultB = 0;

        Plus(x, y, out resultB);

        Console.WriteLine("{0} + {1} = {2}", a, b, resultB);
    }

    public static void Plus(int a, int b, out int c)
    {
        c = a + b;
    }

    public static void Plus(double a, double b, out double c)
    {
        c = a + b;
    }
}