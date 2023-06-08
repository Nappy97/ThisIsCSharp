class MainApp
{
    static double Square(double arg)
    {
        // 수를 입력하세요 : 3
        // 결과 : 9
        // 34.2 -> 1169.64

        return arg * arg;
    }

    static void Main(string[] args)
    {
        Console.Write("수를 입력하세요 : ");
        var input = Console.ReadLine();
        double arg = Convert.ToDouble(input);

        Console.WriteLine("결과 : {0}", Square(arg));
    }
}