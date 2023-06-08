using System;
using static System.Console;

namespace ConsoleAppA_8;

class MainApp
{
    static void Main(string[] args)
    {
        var name = "김튼튼";
        var age = 23;
        WriteLine($"{name,-10}, {age:D3}");

        name = "박날씬";
        age = 30;
        WriteLine($"{name}, {age,10:D3}");

        name = "이비실";
        age = 17;
        WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
    }
}