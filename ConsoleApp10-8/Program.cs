using System.Collections;

class MainApp
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < 5; i++)
            list.Add(i);

        foreach (var obj in list)
            Console.Write($"{obj} ");
        Console.WriteLine();

        list.RemoveAt(2);

        foreach (var obj in list)
            Console.Write($"{obj} ");
        Console.WriteLine();

        list.Add("abc");
        list.Add("def");

        for (int i = 0; i < list.Count; i++)
            Console.Write($"{list[i]} ");

        Console.WriteLine();
    }
}

