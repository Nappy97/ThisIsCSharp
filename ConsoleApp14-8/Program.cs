using System.Linq.Expressions;

class MainApp
{
    static void Main(string[] args)
    {
        int[] array = { 11, 22, 33, 44, 55 };

        foreach (var a in array)
        {
            // var action = new Action(
            //     delegate() { Console.WriteLine(a * a); });
            // action.Invoke();

            Expression<Func<int, int>> expression =
                (a) => a * a;
            Func<int, int> func = expression.Compile();

            Console.WriteLine($"{func(a)}");
        }
    }
}