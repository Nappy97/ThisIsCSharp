class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("숫자를 입력해주세요 : ");

        var input = Console.ReadLine();
        var number = Int32.Parse(input);

        if (number < 0)
            Console.WriteLine("음수");
        else if (number > 0)
            Console.WriteLine("양수");
        else
            Console.WriteLine("0");

        if (number % 2 == 0)
            Console.WriteLine("짝수");
        else
            Console.WriteLine("홀수");
    }
}