using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Harry Potter");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            //book.grades.Add(101);

            var grades = new List<double>() {12.7, 7.3, 10, 5};
            grades.Add(15);

            var result = 0.0;

            foreach(double number in grades){
                result += number;
            }

            var average = result/grades.Count;

            Console.WriteLine($"Result: {result:N1} Average: {average:N1}");
        }
    }
}
