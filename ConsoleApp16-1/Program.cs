using System.Reflection;

namespace ConsoleApp16_1;

class MainApp
{
    static void PrintInterface(Type type)
    {
        Console.WriteLine("-------- Interfaces --------");

        Type[] interfaces = type.GetInterfaces();
        foreach (var i in interfaces)
            Console.WriteLine("Name : {0}", i.Name);

        Console.WriteLine();
    }

    static void PrintFields(Type type)
    {
        Console.WriteLine("-------- Fields --------");

        FieldInfo[] fields = type.GetFields(
            BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

        foreach (var field in fields)
        {
            var accessLevel = "protected";
            if (field.IsPublic) accessLevel = "public";
            else if (field.IsPrivate) accessLevel = "private";

            Console.WriteLine("Access : {0}, Type {1}, Name : {2}",
                accessLevel, field.FieldType.Name, field.Name);
        }

        Console.WriteLine();
    }

    static void PrintMethods(Type type)
    {
        Console.WriteLine("-------- Methods --------");

        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.Write("Type : {0}, Name : {1}, Parameter : ",
                method.ReturnType.Name, method.Name);

            ParameterInfo[] args = method.GetParameters();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i].ParameterType.Name);
                if (i < args.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void PrintProperties(Type type)
    {
        Console.WriteLine("-------- Methods --------");

        PropertyInfo[] properties = type.GetProperties();
        foreach (var property in properties)
            Console.WriteLine("Type : {0}, Name : {1}", property.PropertyType.Name, property.Name);

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        var a = 0;
        Type type = a.GetType();
        
        PrintInterface(type);
        PrintFields(type);
        PrintProperties(type);
        PrintMethods(type);
    }
}