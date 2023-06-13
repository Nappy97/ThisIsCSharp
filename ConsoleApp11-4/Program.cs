class MainApp
{
    static void Main(string[] args)
    {
        var list = new List<int>();
        for (int i = 0; i < 5; i++)
            list.Add(i);

        foreach (var element in list)
            Console.Write($"{element} ");
        Console.WriteLine();
        
        list.RemoveAt(2);

        foreach (var element in list)
            Console.Write($"{element} ");
        Console.WriteLine();
        
        list.Insert(2,2);

        foreach (var element in list)
            Console.Write($"{element} ");
        Console.WriteLine();
    }
}