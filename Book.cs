using System;
using System.Collections.Generic;
namespace GradeBook
{
class Book
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

        public void ShowStatistic()
        {
            var grades = new List<double>() {12.7,10.3,6.11,4.1};
            grades.Add(56.1);
            var result = 0.0;
            var lowGrade = double.MinValue;
            var highGrade = double.MaxValue;
            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}");
            Console.WriteLine($"The average grade in 2 decimals {result:N2}");
            Console.WriteLine($"The average grade in 3 decimals {result:N3}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            
           /* if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
            */
        }

        public List<double> grades; //granting public access
        ///private List<double> grades; //granting public access
        private string name;
    }
}