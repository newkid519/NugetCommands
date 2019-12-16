using System;
using Newtonsoft.Json;

namespace NugetCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(JsonConvert.SerializeObject(new { a = "value" }));
        }
    }
}
