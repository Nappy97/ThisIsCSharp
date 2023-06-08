﻿class BirthdayInfo
{
    private string name;
    private DateTime birthday;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public DateTime Birthday
    {
        get
        {
            return birthday;
        }
        set
        {
            birthday = value;
        }
    }

    public int Age
    {
        get
        {
            return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
        }
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        BirthdayInfo birth = new BirthdayInfo();
        birth.Name = "의형";
        birth.Birthday = new DateTime(1997, 08, 29);

        Console.WriteLine($"Name : {birth.Name}");
        Console.WriteLine($"Birthday : {birth.Birthday}");
        Console.WriteLine($"Age : {birth.Age}");
    }
}