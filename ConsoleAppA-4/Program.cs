// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Total : {0, -7: D}", 123); // 첨자 0, 맞춤-7, 서식 문자열 D

        string result = string.Format("{0}DEF", "ABC");
        string result1 = string.Format("{0, -10}DEF", "ABC");
        Console.WriteLine(result);
        Console.WriteLine(result1);
    }
}