using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(double number in grades){
                highGrade = Math.Max(number,highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            var average = result/grades.Count;

            Console.WriteLine($"Result: {result:N1} Average: {average:N1}, Min: {lowGrade} and Max: {highGrade}");
        }

        private List<double> grades;
        private string name;
    }
}