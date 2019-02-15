using System;

namespace NormalFactory.DemoProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestInfo theValue = new TestInfo()
            {
                Name = "Scott"
            };

            Console.WriteLine($"Hello World! This is {theValue.Name}; this is a test!");
        }
    }
}
