class MainApp
{
    static void Main(string[] args)
    {
        var someValue = 0x123456789ABCDEF0;
        Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

        Stream outStream = new FileStream("a.dat", FileMode.Create);
        var wBytes = BitConverter.GetBytes(someValue);

        Console.WriteLine("{0,-13} : ", "Byte array");

        foreach (var b in wBytes)
            Console.Write("{0:X2} " , b);
        Console.WriteLine();
        
        outStream.Write(wBytes, 0, wBytes.Length);
        outStream.Close();

        Stream inStream = new FileStream("a.dat", FileMode.Open);
        var rbytes = new byte[8];

        var i = 0;
        while (inStream.Position < inStream.Length)
            rbytes[i++] = (byte)inStream.ReadByte();

        var readValue = BitConverter.ToInt64(rbytes, 0);

        Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
        inStream.Close();
    }
}