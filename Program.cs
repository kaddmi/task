using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(4);
            var avgMark = 0.0;
            st1.FullName = "A. J. Pischik";
            try
            {
                st1.Marks[0] = new Mark("math", 7);
                st1.Marks[1] = new Mark("physics", 9);
                st1.Marks[2] = new Mark("chemistry", 8);
                st1.Marks[3] = new Mark("english", 9);
                Console.WriteLine("full name - " + st1.FullName);
                Console.WriteLine("number of subjects = " + st1.Marks.Length);
                foreach(Mark m in st1.Marks)
                {
                    Console.WriteLine("subject - " + m.Subject);
                    Console.WriteLine("mark = " + m.SMark);
                }
                st1.GetAvgMark(out avgMark);
                Console.WriteLine("average mark of the " + st1.FullName + " = " + avgMark);
                st1.ResetAllMarks();
                st1.GetAvgMark(out avgMark);
                Console.WriteLine("average mark of the " + st1.FullName + " = " + avgMark);
            }
            catch(ArgumentOutOfRangeException outOfRange)
            {   
                Console.WriteLine("Error: {0}", outOfRange.Message);
            }
            Console.Read();
        }
    }
}
