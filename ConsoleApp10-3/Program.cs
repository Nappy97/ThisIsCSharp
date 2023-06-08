class MainApp
{
    static void Main(string[] args)
    {
        var array = new int[] { 10, 30, 20, 7, 1 };
        Console.WriteLine($"Type Of array : {array.GetType()}");
        Console.WriteLine($"Base type Of aaray : {array.GetType().BaseType}");
    }
}