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
            double[] numbers = new double[1];
            numbers[0] = 12.7;
            Console.WriteLine(numbers);
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
