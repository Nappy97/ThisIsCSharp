namespace ConsoleApp3_9;
// StringNumberConversion

class MainApp
{
    static void Main(string[] args)
    {
        int a = 123;
        string b = a.ToString();
        string b1 = Convert.ToString(a);
        Console.WriteLine(b);
        Console.WriteLine(b1);

        float c = 3.14f;
        string d = c.ToString();
        string d1 = Convert.ToString(c);
        Console.WriteLine(d);
        Console.WriteLine(d1);

        string e = "123456";
        int f = Convert.ToInt32(e);
        int f1 = int.Parse(e);
        Console.WriteLine(f);
        Console.WriteLine(f1);

        string g = "1.2345";
        float h = float.Parse(g);
        decimal h1 = Convert.ToDecimal(g);
        Console.WriteLine(h);
        Console.WriteLine(h1);
    }
}