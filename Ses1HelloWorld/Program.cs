using System;

namespace Ses1HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Welcome to ");
            //Console.WriteLine("C# programming!");
            //Console.WriteLine("{0}\n{1}", "Welcome to", "C# programming!");

            Console.WriteLine("Please input your name");
            String name = Console.ReadLine();
            Console.WriteLine("Welcome {0} to C# programming!", name);
            Console.WriteLine("Please input your age: ");

            String ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            Console.WriteLine("You are {0} years old", age);

            Console.Read();
        }
    }
}
