﻿namespace ConsoleApp13_6;

delegate void EventHandler(string message);

class MyNotifier
{
    public event EventHandler SomethingHappened;

    public void DoSomething(int number)
    {
        var temp = number % 10;

        if (temp != 0 && temp % 3 == 0)
        {
            SomethingHappened(String.Format("{0} : 짝", number));
        }
    }
}

class MainApp
{
    static public void MyHandler(string message)
    {
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
        var notifier = new MyNotifier();
        notifier.SomethingHappened += new EventHandler(MyHandler);

        for (int i = 1; i < 30; i++)
        {
            notifier.DoSomething(i);
        }
    }
}