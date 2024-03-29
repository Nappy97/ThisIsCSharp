﻿interface INamedValue
{
    string Name { get; set; }

    string Value { get; set; }
}

class NamedValue : INamedValue
{
    public string Name { get; set; }
    public string Value { get; set; }
}

class MainApp
{
    static void Main(string[] args)
    {
        NamedValue name = new NamedValue()
        {
            Name = "이름",
            Value = "정의형"
        };

        NamedValue height = new NamedValue()
        {
            Name = "키",
            Value = "177CM"
        };

        NamedValue weight = new NamedValue()
        {
            Name = "몸무게",
            Value = "90KG"
        };

        Console.WriteLine($"{name.Name} : {name.Value}");
        Console.WriteLine($"{height.Name} : {height.Value}");
        Console.WriteLine($"{weight.Name} : {weight.Value}");
    }
}