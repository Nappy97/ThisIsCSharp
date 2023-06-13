using System.Collections;

class MyClass
{
    static void Main(string[] args)
    {
        var ht = new Hashtable();

        ht["회사"] = "Microsoft";
        ht["URL"] = "www.microsoft.com";

        Console.WriteLine("회사 : {0}", ht["회사"]);
        Console.WriteLine("URL : {0}", ht["URL"]);
    }
}