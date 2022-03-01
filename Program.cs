using System;

namespace LineComparisonProblems  // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparison Computation program");
            LineComparisonProblem.Sample.CaluculateRoot();
            LineComparisonProblem.CheckQuality.EqualLines();
            LineComparisonProblem.GreaterOrLess.CompareLine();

        }
    }
}
