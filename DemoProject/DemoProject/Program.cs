using System;

namespace NormalFactory.DemoProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestInfo theValue = new TestInfo()
            {
                Name = "Scott",
                Age = 21,
            };

            Console.WriteLine($"Hello World! This is {theValue.Name}; this is a test!  You are {theValue.Age.ToString()}");
        }
    }
}
