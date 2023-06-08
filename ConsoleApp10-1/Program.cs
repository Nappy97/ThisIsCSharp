class MainApp
{
    static void Main(string[] args)
    {
        var scores = new int[5];
        scores[0] = 80;
        scores[1] = 74;
        scores[2] = 81;
        scores[3] = 90;
        scores[4] = 34;

        foreach (var score in scores)
            Console.WriteLine(score);

        var sum = 0;
        foreach (var score in scores)
            sum += score;

        int average = sum / scores.Length;

        Console.WriteLine($"Average Score : {average}");
    }
}