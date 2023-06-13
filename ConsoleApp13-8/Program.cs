namespace ConsoleApp13_8;

delegate void MyDelegate(int a);

class Market
{
    public event MyDelegate CustomerEvent;

    public void BuySomething(int CustomerNo)
    {
        if (CustomerNo == 30)
            CustomerEvent(CustomerNo);
    }
}

class MainApp
{
    
    static public void MyHandler(int no)
    {
        Console.WriteLine($"축하합니다! {no}번째 고객 이벤트에 당첨되었습니다.");
    }
    
    static void Main(string[] args)
    {
        var market = new Market();
        market.CustomerEvent += new MyDelegate(MyHandler);

        for (int customerNo = 0; customerNo < 100; customerNo++)
            market.BuySomething(customerNo);
    }
}