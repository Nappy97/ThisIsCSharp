class Employee
{
    private string Name;
    private string Position;

    public string Name1
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Position1
    {
        get => Position;
        set => Position = value ?? throw new ArgumentNullException(nameof(value));
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var pooh = new Employee();
        pooh.Name1 = "Pooh";
        pooh.Position1 = "Waiter";

        Console.WriteLine($"{pooh.Name1} {pooh.Position1}");

        var tigger = new Employee();
        tigger.Name1 = "Tigger";
        tigger.Position1 = "Cleaner";
        Console.WriteLine($"{tigger.Name1} {tigger.Position1}");
    }
}