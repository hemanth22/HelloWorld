using System;

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
            var numbers = new[] {12.7,10.3,6.11,4.1};
            var result = numbers[0];
            result += numbers[1];
            result += numbers[2];
            Console.WriteLine(result);
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
