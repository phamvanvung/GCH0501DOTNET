using System;

namespace Ses4SimpleClassExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fun with class types");
            Car c = new Car();
            //c.petName = "Henry";
            //c.currSpeed = 10;
            c.PrintState();
            for (int i = 0; i < 10; i++)
            {
                c.SpeedUp(5);
                c.PrintState();
            }
            //Henry
            Car c1 = new Car("Henry");
            c1.PrintState();
            //Bob
            Car c2 = new Car("Bob", 50);
            c2.PrintState();
            Console.Read();
        }

    }
}
