namespace ConsoleApp14_7;

class FriendList
{
    private List<string> list = new List<string>();

    public void Add(string name) => list.Add(name);

    public void Remove(string name) => list.Remove(name);

    public void PrintAll()
    {
        foreach (var s in list)
            Console.WriteLine(s);
    }

    public FriendList() => Console.WriteLine("FriendList()");
    ~FriendList() => Console.WriteLine("~FriendList()");

    public int Capacity // 속성
    {
        get => list.Capacity;
        set => list.Capacity = value;
    }

    // public string this[int index] => list[index];   // 읽기전용
    public string this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var obj = new FriendList();
        obj.Add("Eney");
        obj.Add("Meeny");
        obj.Add("Miny");
        obj.Remove("Eney");
        obj.PrintAll();

        Console.WriteLine($"{obj.Capacity}");
        obj.Capacity = 10;
        Console.WriteLine($"{obj.Capacity}");

        Console.WriteLine($"{obj[0]}");
        obj[0] = "Moe";
        Console.WriteLine($"{obj[0]}");
    }
}