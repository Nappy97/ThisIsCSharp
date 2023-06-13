using System.Linq.Expressions;

class MainApp
{
    static void Main(string[] args)
    {
        Expression<Func<int, int, int>> expression = (a, b) => 1 * 2 + (a - b);
        var func = expression.Compile();

        // x = 7, y = 8
        Console.WriteLine($"1 * 2 + ({7} - {8}) = {func(7, 8)}");
    }
}