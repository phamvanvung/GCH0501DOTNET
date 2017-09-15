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
        public void ClassAverage(){
            int counter = 0;
            int total=0;
            while(counter<10){
                Console.WriteLine("Please enter a grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                total += grade;
                counter++;
            }
            Console.WriteLine("Total of all 10 grades is: {0}", total);
            float average = (float)total / counter;
            Console.WriteLine("The average is: {0}",average);
        }
    }
}
