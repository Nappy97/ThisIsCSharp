class MainApp
{
    static void Main(string[] args)
    {
        try
        {
            var a = 1;
            Console.WriteLine(3 / --a);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
}