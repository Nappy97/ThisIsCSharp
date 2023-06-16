using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

class MainApp
{
    static void Main(string[] args)
    {
        ScriptEngine engine = Python.CreateEngine();
        ScriptScope scope = engine.CreateScope();
        scope.SetVariable("n", "정의형");
        scope.SetVariable("p", "010-1234-5678");

        ScriptSource source = engine.CreateScriptSourceFromString(
            @"
class NameCard:
    name = ''
    phone = ''

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone

    def printNameCard(self):
        print(self.name + ', ' + self.phone)
        
NameCard(n, p) 
");
        dynamic result = source.Execute(scope);

        result.printNameCard();

        Console.WriteLine("{0}, {1}", result.name, result.phone);
    }
}