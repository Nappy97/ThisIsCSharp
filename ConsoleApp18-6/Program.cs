class MainApp
{
    static void Main(string[] args)
    {
        var sw =
            new StreamWriter(
                new FileStream("a.txt", FileMode.Create));
        
        sw.WriteLine(int.MaxValue);
        sw.WriteLine("Good morning!");
        sw.WriteLine(uint.MaxValue);
        sw.WriteLine("안녕하세요!");
        sw.WriteLine(double.MaxValue);
        
        sw.Close();

        var sr =
            new StreamReader(
                new FileStream("a.txt", FileMode.Open));

        Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

        while (sr.EndOfStream == false)
        {
            Console.WriteLine(sr.ReadLine());
        }
    }
}