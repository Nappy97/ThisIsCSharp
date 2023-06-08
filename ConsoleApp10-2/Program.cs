class MainApp
{
    static void Main(string[] args)
    {
        var array1 = new string[3] { "안녕", "Hello", "Halo" };

        Console.WriteLine("\narray1 ...");
        foreach (var greeting in array1)
            Console.WriteLine($"{greeting}");

        var array2 = new string[] { "안녕", "Hello", "Halo" };

        Console.WriteLine("\narray2 ... ");
        foreach (var greeting in array2)
            Console.WriteLine($"{greeting}");

        string[] array3 = { "안녕", "Hello", "Halo" };

        Console.WriteLine("\narray3 ... ");
        foreach (var greeting in array3)
            Console.WriteLine($"{greeting}");
        
    }
}