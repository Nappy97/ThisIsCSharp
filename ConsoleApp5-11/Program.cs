class MyClass
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("계속할까요 (Y/N)");
            var answer = Console.ReadLine();

            if (answer == "N")
                break;
        }
    }
}