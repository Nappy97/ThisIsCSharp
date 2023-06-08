namespace ConsoleAppA_3;

class MainApp
{
    static void Main(string[] args)
    {
        var greeting = "Good morning";

        // SubString() -> 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환
        Console.WriteLine(greeting.Substring(0, 5)); // "Good"
        Console.WriteLine(greeting.Substring(5));   // "morning"
        Console.WriteLine();

        // Split() -> 지정된 문자를 기준으로 분리한 문자여르이 배열을 반환
        var arr = greeting.Split(
            new string[]{" "}, StringSplitOptions.None);

        Console.WriteLine("Word Count : {0}", arr.Length);

        foreach (var element in arr)
        {
            Console.WriteLine("{0}", element);
        }
        
    }
}