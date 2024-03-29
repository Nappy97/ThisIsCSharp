﻿class BirthdayInfo
{
    public string Name { get; set; } = "Unknown";
    public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);

    public int Age
    {
        get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        BirthdayInfo birth = new BirthdayInfo();
        Console.WriteLine($"Name : {birth.Name}");
        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
        Console.WriteLine($"Age : {birth.Age}");

        birth.Name = "의형";
        birth.Birthday = new DateTime(1997, 08, 29);
        Console.WriteLine($"Name : {birth.Name}");
        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
        Console.WriteLine($"Age : {birth.Age}");
    }
}