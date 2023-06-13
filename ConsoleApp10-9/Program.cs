using System.Collections;

class MainApp
{
    static void Main(string[] args)
    {
        var que = new Queue();
        que.Enqueue(1);
        que.Enqueue(2);
        que.Enqueue(3);
        que.Enqueue(4);
        que.Enqueue(5);

        while (que.Count > 0)
            Console.WriteLine(que.Dequeue());

        Console.WriteLine(que.Count);
    }
}