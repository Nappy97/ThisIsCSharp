using static System.Console;

namespace ConsoleAppA_2;

class MyClass
{
    static void Main(string[] args)
    {
        // ToLower() -> 소문자화 시켜서 새 문자열로 반환
        WriteLine("ToLower() : '{0}'", "ABC".ToLower());

        // ToUpper() -> 대문자화 시켜서 새 문자열로 반환
        WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

        // Insert() -> 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환
        WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));

        // Remove() -> 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환
        WriteLine("Remove() : '{0}'", "I Don't Love you".Remove(2, 6));

        // Trim() -> 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환
        WriteLine("Trim() : '{0}'", "        No Spaces          ".Trim());

        // TrimStart() -> 앞에 있는 공백을 삭제한 새 문자열을 반환
        WriteLine("TrimStart() : '{0}'", "        No Spaces          ".TrimStart());

        // TrimENd() -> 뒤에 있는 공백을 삭제한 새 문자열을 반환
        WriteLine("TrimEnd() : '{0}'", "        No Spaces          ".TrimEnd());
    }
}