using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_generic_collection
{
    struct Answer
    {
        public Answer(int points, int whichOne) 
        {
            Points = points;
            WhichOne = whichOne;
        }
        public int Points { get; set; }
        public int WhichOne { get; set; }
    }
    internal class Student
    {
        public Student(string name, List<int> examPoints) 
        {
            Name = name;
            ExamPoints = examPoints;
        }

        public string Name { get; set; }
        public List<int> ExamPoints { get; set; }

        //Instance methods here:

        public int CalculateSum()
        {
            int numberOfElements = ExamPoints.Count;
            int sumTotal = 0;
            for (int i = 0; i < numberOfElements; i++)
            {
                sumTotal = sumTotal + ExamPoints[i];
            }
            return sumTotal;
        }
        public int CalculateGrade()
        {
            int grade;
            int sumTotal = CalculateSum();
            if (sumTotal < 26)
                grade = 0;
            else if (sumTotal < 31)
                grade = 1;
            else if (sumTotal < 36)
                grade = 2;
            else if (sumTotal < 41)
                grade = 3;
            else if (sumTotal < 46)
                grade = 4;
            else
                grade = 5;
            return grade;
        }
        public Answer FindExamWithMinPoints()
        {
            int smallest = ExamPoints.Min();
            int index = ExamPoints.IndexOf(ExamPoints.Min());
            Answer answer = new Answer(smallest, index);
            return answer;
        }
    }
}
