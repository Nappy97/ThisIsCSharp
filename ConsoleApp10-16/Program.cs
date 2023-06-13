using System.Collections;

class MyClass
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        var queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}