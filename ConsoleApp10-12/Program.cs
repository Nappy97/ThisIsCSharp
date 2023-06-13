using System.Collections;

class MainApp
{
    static void Main(string[] args)
    {
        int[] arr = { 123, 456, 789 };

        var list = new ArrayList(arr);
        foreach (var item in list)
            Console.WriteLine($"ArrayList : {item}");
        Console.WriteLine();

        var stack = new Stack(arr);
        foreach (var item in stack)
            Console.WriteLine($"Stack : {item}");
        Console.WriteLine();

        var queue = new Queue(arr);
        foreach (var item in queue)
            Console.WriteLine($"Queue : {item }");
        Console.WriteLine();

        var list2 = new ArrayList() { 11, 22, 33 };
        foreach (var item in list2)
            Console.WriteLine($"ArrayList2 : {item}");
        Console.WriteLine();
    }
}