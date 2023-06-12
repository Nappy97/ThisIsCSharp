class MyClass
{
    static void Main(string[] args)
    {
        var arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"[{i}, {j}] : {arr[i, j]}");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        var arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.WriteLine($"[{i}, {j}] : {arr2[i, j]}");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        var arr3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                Console.WriteLine($"[{i}, {j}] : {arr3[i, j]}");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}