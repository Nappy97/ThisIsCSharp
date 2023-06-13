using System.Collections;

class MyList : IEnumerator, IEnumerable
{
    private int[] array;

    // 컬렉션의 현재위치를 다루는 변수, 초기값은 -1이다.
    // 이유는 만약 값이 - 이라면 FOREACH 문이 첫번째 반복을 수행하면 MoverNext() 메소드를 실행하고, 1이되어서 두번쨰요소가 실행되는 문제 발생
    private int position = -1;

    public MyList()
    {
        array = new int[3];
    }

    public int this[int index]
    {
        get { return array[index]; }

        set
        {
            if (index >= array.Length)
            {
                Array.Resize<int>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }

            array[index] = value;
        }
    }


    public bool MoveNext()
    {
        if (position == array.Length - 1)
        {
            Reset();
            return false;
        }

        position++;
        return (position < array.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get { return array[position]; }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < array.Length; i++)
        {
            yield return (array[i]);
        }
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var list = new MyList();
        for (int i = 0; i < 5; i++)
            list[i] = i;

        foreach (int e in list)
            Console.WriteLine(e);
    }
}