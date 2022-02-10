using System;
using Inizio;

namespace Inizio {
    class Program{
        static void Main(string[] args)
        {
        string Output = LogLine.Message("[ERROR]: Invalid operation");
        Console.WriteLine(Output);
        string Output2 = LogLine.LogLevel("[ERROR]: Invalid operation");
        Console.WriteLine(Output2);
        string Output3 = LogLine.Reformat("[INFO]: Operation completed");
        Console.WriteLine(Output3);
        }
    }
}