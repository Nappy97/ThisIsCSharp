using static System.Console;

namespace ConsoleAppA_1;

class MainApp
{
    static void Main(string[] args)
    {
        var greeting = "Good Morning";

        WriteLine(greeting);
        WriteLine();

        // IndexOf() -> 현재 문자열 내에서 찾고자하는 문자 또는 문자열의 위치를 찾음
        WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
        WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

        // LastIndexOf() -> 뒤에서부터 찾기
        WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
        WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

        // StartsWith() -> 현재 문자열이 지정된 문자열로 시작하는지를 평가
        WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
        WriteLine("StartsWith 'Morining' : {0}", greeting.StartsWith("Morning"));

        // EndsWith() -> 현재 문자열이 지정된 문자열로 끝나는지를 평가
        WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
        WriteLine("EndsWith 'Morining' : {0}", greeting.EndsWith("Morning"));

        // Contains() -> 지정된 문자열을 포함하는지 여부
        WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
        WriteLine("Contains 'Morining' : {0}", greeting.Contains("Morning"));

        // Replace() -> 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환
        WriteLine("Replaced 'Morning' with 'Evening' : {0}",
            greeting.Replace("Morning", "Evening"));
    }
}