using System.Linq.Expressions;

class MainApp
{
    static void Main(string[] args)
    {
        // 1 + 2 + (x - y)
        var const1 = Expression.Constant(1);
        var const2 = Expression.Constant(2);

        var leftExp = Expression.Multiply(const1, const2); // 1 + 2

        var param1 = Expression.Parameter(typeof(int)); // X를 위한 변수
        var param2 = Expression.Parameter(typeof(int)); // Y를 위한 변수

        var rightExp = Expression.Subtract(param1, param2); // X + Y

        var exp = Expression.Add(leftExp, rightExp);

        var expression = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
            exp, new ParameterExpression[]
            {
                (ParameterExpression)param1,
                (ParameterExpression)param2
            });

        var func = expression.Compile();

        // x = 7, y = 8
        Console.WriteLine($"1 * 2 + ({7} - {8}) = {func(7, 8)}");
    }
}