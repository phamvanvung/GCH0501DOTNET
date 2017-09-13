using System;

namespace Ses2GradeBook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Please input a course name: ");
			string x = Console.ReadLine();
            GradeBook gradeBook = new GradeBook(x);
            gradeBook.DisplayMessage();

            Console.Read();
        }
    }
}
