class MyClass
{
    static void Main(string[] args)
    {
        var dic = new Dictionary<string, string>();

        dic["하나"] = "ONE";
        dic["둘"] = "TWO";

        Console.WriteLine(dic["하나"]);
        Console.WriteLine(dic["둘"]);
    }
}