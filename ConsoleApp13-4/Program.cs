namespace ConsoleApp13_4;

delegate void Notify(string message);

class Notifier
{
    public Notify EventOccured;
}

class EventListener
{
    private string name;

    public EventListener(string name)
    {
        this.name = name;
    }

    public void SomethingHappend(string message)
    {
        Console.WriteLine($"{name}.SomethingHappend : {message}");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        var notifier = new Notifier();
        var listener1 = new EventListener("Listener1");
        var listener2 = new EventListener("Listener2");
        var listener3 = new EventListener("Listener3");
        notifier.EventOccured += listener1.SomethingHappend;
        notifier.EventOccured += listener2.SomethingHappend;
        notifier.EventOccured += listener3.SomethingHappend;
        notifier.EventOccured("You've got mail.");

        Console.WriteLine();

        notifier.EventOccured -= listener2.SomethingHappend;
        notifier.EventOccured("Download complete");

        Console.WriteLine();

        notifier.EventOccured = new Notify(listener2.SomethingHappend)
                                + new Notify(listener3.SomethingHappend);
        notifier.EventOccured("Nuclear launch detected.");

        Console.WriteLine();

        var notify1 = new Notify(listener1.SomethingHappend);
        var notify2 = new Notify(listener2.SomethingHappend);

        notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
        notifier.EventOccured("Fire!!");

        Console.WriteLine();

        notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
        notifier.EventOccured("RPG!");
    }
}