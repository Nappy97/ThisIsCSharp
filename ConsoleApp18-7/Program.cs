using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp18_7;

[Serializable]
class NameCard
{
    public string Name;
    public string Phone;
    public int Age;
}

class MainApp
{
    static void Main(string[] args)
    {
        var ws = new FileStream("a.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter();

        var nc = new NameCard();
        nc.Name = "정의형";
        nc.Phone = "010-8245-6378";
        nc.Age = 25;
        
        serializer.Serialize(ws, nc);
        ws.Close();

        var rs = new FileStream("a.dat", FileMode.Open);
        BinaryFormatter deserializer = new BinaryFormatter();

        NameCard nc2;
        nc2 = (NameCard)deserializer.Deserialize(rs);
        rs.Close();

        Console.WriteLine($"Name    : {nc2.Name}");
        Console.WriteLine($"Phone   : {nc2.Phone}");
        Console.WriteLine($"Age     : {nc2.Age}");
    }
}