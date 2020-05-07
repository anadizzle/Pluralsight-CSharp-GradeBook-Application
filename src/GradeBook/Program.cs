using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book? book = new InMemoryBook("Happy Potter");
            
            book.GradeAdded += OnGradedAdded;
            
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book with name{book.Name}");
            Console.WriteLine($"Result: Average: {stats.Average:N1}, Min: {stats.Low} and Max: {stats.High} The Letter Grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook? book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradedAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
