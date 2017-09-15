using System;

namespace Ses3BreakVsContinue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //break
            Console.WriteLine("Break test:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i==5){
                    break;
                }
            }
            Console.WriteLine("Continue test: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i==5){
                    continue;   
                }
            }
        }
    }
}
