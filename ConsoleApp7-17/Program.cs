class MainApp
{
    static void Main(string[] args)
    {
        // 명명되지 않은 튜플
        var a = ("슈퍼맨", 9999);
        Console.WriteLine($"{a.Item1}, {a.Item2}");

        // 명명된 튜플
        var b = (Name: "정의형", Age: 25);
        Console.WriteLine($"{b.Name}, {b.Age}");
        
        // 분해
        var (name, age) = b;
        Console.WriteLine($"{name}, {age}");
        
        // 명명된 튜플 = 명명되지 않은 튜플
        b = a;
        Console.WriteLine($"{b.Name}, {b.Age}");
    }
}