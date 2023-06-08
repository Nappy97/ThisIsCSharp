class NameCard
{
    public int age { get; set; }
    public string name { get; set; }
}

class MainApp
{
    public static void Main(string[] args)
    {
        NameCard MyCard = new NameCard();

        MyCard.age = 24;
        MyCard.name = "상현";

        Console.WriteLine("나이 : {0}", MyCard.age);
        Console.WriteLine("이름 : {0}", MyCard.name);
    }
}