class BirthdayInfo
{
    public string Name
    {
        get;
        set;
    }

    public DateTime Birthday
    {
        get;
        set;
    }

    public int Age
    {
        get
        {
            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
        }
    }
    
}

class MainApp
{
    static void Main(string[] args)
    {
        BirthdayInfo birth = new BirthdayInfo()
        {
            Name = "의형",
            Birthday = new DateTime(1997, 08, 29)
        };

        Console.WriteLine($"Name : {birth.Name}");
        Console.WriteLine($"Birthday : {birth.Birthday}");
        Console.WriteLine($"Age : {birth.Age}");
    }
}