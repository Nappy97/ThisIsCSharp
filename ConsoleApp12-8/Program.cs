class MainApp
{
    static void Main(string[] args)
    {
        var arr = new int[10];

        for (int i = 0; i < 10; i++)
            arr[i] = i;

        try
        {
            for (int i = 0; i < 11; i++)
                Console.WriteLine(arr[i]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("숫자가 커버불가능");
        }
    }
}