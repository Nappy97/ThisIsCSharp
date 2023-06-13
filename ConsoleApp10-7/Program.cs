using Console = System.Console;

class MyClass
{
    static void Main(string[] args)
    {
        // 가변배열(들쭉날쭉한 배열->직역)
        var jagged = new int [3][];
        jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
        jagged[1] = new int[] { 10, 20, 30 };
        jagged[2] = new int[] { 100, 200 };

        foreach (var arr in jagged)
        {
            Console.Write($"Length : {arr.Length}, ");
            foreach (var e in arr)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine("");
        }

        Console.WriteLine("");

        var jagged2 = new int[2][]
            { new int[] { 1000, 2000 }, new int[4] { 6, 7, 8, 9 } };

        foreach (var arr in jagged2)
        {
            Console.Write($"Length : {arr.Length}, ");
            foreach (var e in arr)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();

        }

    }
}