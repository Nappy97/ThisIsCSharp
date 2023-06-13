class MainApp
{
    static void Main(string[] args)
    {
        try
        {
            int? a = null;
            int b = a ?? throw new ArgumentNullException();
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e);
        }

        try
        {
            var array = new[] { 1, 2, 3 };
            var index = 4;
            var value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
    }
}