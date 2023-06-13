class MainApp
{
    delegate string Concatenate(string[] args);

    static void Main(string[] args)
    {
        Concatenate concat =
            (arr) =>
            {
                var result = "";
                foreach (var s in arr)
                    result += 5;

                return result;
            };

        Console.WriteLine(concat);
    }
}