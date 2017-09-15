using System;

namespace Ses2GradeBook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Console.WriteLine("Please input a course name: ");
			//string x = Console.ReadLine();
            //GradeBook gradeBook = new GradeBook(x);
            //gradeBook.DisplayMessage();
            //gradeBook.ClassAverage();
            //Test increment/decrement operators
            int a = 10;
            Console.WriteLine(a++);//10
            Console.WriteLine(a);//11

            int b = 10;
            Console.WriteLine(++b);//11
            Console.WriteLine(b);//11

            Console.Read();
        }
    }
}
