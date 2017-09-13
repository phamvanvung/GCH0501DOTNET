using System;
namespace Ses2GradeBook
{
    public class GradeBook
    {
        //private string courseName;//instance variable
        //public string CourseName //property
        //{
        //    get{//getter
        //        //...
        //        return courseName;
        //    }
        //    set{//setter
        //        //...
        //        courseName = value;
        //    }
        //}
        public GradeBook(string y)
        {
            CourseName = y;
        }
        public string CourseName{ get; set;}
        public void DisplayMessage(){
            Console.WriteLine("Welcome to GradeBook for {0}", CourseName);
        }
    }
}
