using System.Collections;

class MyEnumerator
{
    private int[] numbers = { 1, 2, 3, 4 };

    public IEnumerator GetEnumerator()
    {
        yield return numbers[0];
        yield return numbers[1];
        yield return numbers[2];
        yield break;    // -> yield breake는 해당 메소드를 종료시킴
        yield return numbers[3];    // -> 즉, 이 문장은 실행 X
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var obj = new MyEnumerator();
        foreach (var i in obj)
            Console.WriteLine(i);
    }
}