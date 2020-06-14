using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            ///var x = 34.2;
            ///var y = 10.33;
            ///var result = x + y;
            ///Console.WriteLine(result);
            ///double[] numbers = new double[1];
            ///var numbers = new double[1];
            ///var numbers = new[] {12.7,10.3,6.11,4.1};
            var book = new Book("Bitroid's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(1.5);
            book.ShowStatistic();
            /*book.grades.Add(101); in-accessiable method
            book.grades.Add(101); //Accessable after public method
            */

        }
    }
}
