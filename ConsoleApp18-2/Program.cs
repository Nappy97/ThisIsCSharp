class MainApp
{
    static void OnWrongPathType(string type)
    {
        Console.WriteLine($"{type} is wrong type");
        return;
    }

    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine(
                "Usage : Touch.exe <Path> [Type:File/Directory]");
            return;
        }

        var path = args[0];
        var type = "File";
        if (args.Length > 1)
            type = args[1];

        if (File.Exists(path) || Directory.Exists(path))
        {
            if (type == "File")
                File.SetLastWriteTime(path, DateTime.Now);
            else if (type == "Directory")
                Directory.SetLastWriteTime(path, DateTime.Now);
            else
            {
                OnWrongPathType(path);
                return;
            }

            Console.WriteLine($"Updated {path} {type}");
        }
        else
        {
            if (type == "File")
                File.Create(path).Close();
            else if (type == "Directory")
                Directory.CreateDirectory(path);
            else
            {
                OnWrongPathType(path);
                return;
            }

            Console.WriteLine($"Created {path} {type}");
        }
    }
}