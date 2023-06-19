namespace ConsoleApp19_4;

class SideTask
{
    private int count;

    public SideTask(int count)
    {
        this.count = count;
    }

    public void KeepAlive()
    {
        try
        {
            Console.WriteLine("Running thread isn't gonna be interrupted");
            Thread.SpinWait(1_000_000_000);
        }
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Clearing resource...");
        }
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var task = new SideTask(100);
        var t1 = new Thread(new ThreadStart(task.KeepAlive));
        t1.IsBackground = false;

        Console.WriteLine("Starting thread...");
        t1.Start();
        
        Thread.Sleep(100);
        Console.WriteLine("Interrupting thread...");
        t1.Interrupt();

        Console.WriteLine("Waiting until thread stops...");
        t1.Join();

        Console.WriteLine("Finished");
    }
}