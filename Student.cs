using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Student
    {
        public string FullName { set; get; }
        public Mark[] Marks { set; get; }

        public Student()
        {
            Marks = new Mark[2];
        }

        public Student(int n)
        {
            Marks = new Mark[n];
        }

        public void GetAvgMark(out double avgMark)
        {
            avgMark = 0.0;
            for (int i = 0; i < Marks.Length; i++)
                avgMark += Marks[i].SMark;
            avgMark = avgMark / Marks.Length;
        }

        public void ResetAllMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
                Marks[i].SMark = 0;
        }
    }
}
